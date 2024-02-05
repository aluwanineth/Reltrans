import { Component, NgModule, Output, Input, EventEmitter, ViewChild, ElementRef, AfterViewInit, OnDestroy, OnInit } from '@angular/core';
import { DxTreeViewModule, DxTreeViewComponent, DxTreeViewTypes } from 'devextreme-angular/ui/tree-view';

import * as events from 'devextreme/events';
import { AuthenticationService } from '../../services/account.service';
import { Customer } from '../../models/customer.model';
import { adminNavigation } from 'src/app/app-navigation';
import { accountantNavigation } from 'src/app/app-accountant';
import { buyerNavigation } from 'src/app/app-buyer';
import { projectManagerNavigation } from 'src/app/app.project.manager';
import { MenuService } from '../../services/menu.service';
import { Result } from '../../models/menu.response.results.model';

@Component({
  selector: 'app-side-navigation-menu',
  templateUrl: './side-navigation-menu.component.html',
  styleUrls: ['./side-navigation-menu.component.scss']
})
export class SideNavigationMenuComponent implements AfterViewInit, OnDestroy, OnInit {
  @ViewChild(DxTreeViewComponent, { static: true })
  menu!: DxTreeViewComponent;
  userRole: Array<string> = [];
  menuResults: Result[] = [];
  currentUser: Customer | null = { email: '',firstName: '',surname:'', accNo: '', companyName:'',contactTelNo:'', memberType: [] };
  @Output()
  selectedItemChanged = new EventEmitter<DxTreeViewTypes.ItemClickEvent>();

  @Output()
  openMenu = new EventEmitter<any>();

  private _selectedItem!: String;
  @Input()
  set selectedItem(value: String) {
    this._selectedItem = value;
    if (!this.menu.instance) {
      return;
    }

    this.menu.instance.selectItem(value);
  }

  private _items!: Record <string, unknown>[];
  get items() {
    if (!this._items) {
      if (this.userRole.includes('Administrator')) {
        this._items = adminNavigation.map((item) => ({ ...item, expanded: !this._compactMode }));
      } else if (this.userRole.includes('Accountant')) {
        this._items = accountantNavigation.map((item) => ({ ...item, expanded: !this._compactMode }));
      }
      else if (this.userRole.includes('Buyer')) {
        this._items = buyerNavigation.map((item) => ({ ...item, expanded: !this._compactMode }));
      }
       else if(this.userRole.includes('Project Manager')){
         this._items = projectManagerNavigation.map((item) => ({ ...item, expanded: !this._compactMode }));
      }
      
    }
    return this._items;
   
  }

  private _compactMode = false;
  @Input()
  get compactMode() {
    return this._compactMode;
  }
  set compactMode(val) {
    this._compactMode = val;

    if (!this.menu.instance) {
      return;
    }

    if (val) {
      this.menu.instance.collapseAll();
    } else {
      this.menu.instance.expandItem(this._selectedItem);
    }
  }

  constructor(private elementRef: ElementRef, private authenticationService: AuthenticationService,
    private menuService: MenuService) { 
    this.authenticationService.user.subscribe(x => this.currentUser = x);

    if (this.currentUser) {
      this.userRole =  this.currentUser.memberType;
     }
  }
  ngOnInit(): void {
    this.getMenuData(this.userRole[0]);
  }

  getMenuData(menuType: string): void {
    this.menuService.getMenuByType(menuType).subscribe(
      (data) => {
        this.menuResults = data.result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  onItemClick(event: DxTreeViewTypes.ItemClickEvent) {
    this.selectedItemChanged.emit(event);
  }

  ngAfterViewInit() {
    events.on(this.elementRef.nativeElement, 'dxclick', (e: Event) => {
      this.openMenu.next(e);
    });
  }

  ngOnDestroy() {
    events.off(this.elementRef.nativeElement, 'dxclick');
  }
}

@NgModule({
  imports: [ DxTreeViewModule ],
  declarations: [ SideNavigationMenuComponent ],
  exports: [ SideNavigationMenuComponent ]
})
export class SideNavigationMenuModule { }
