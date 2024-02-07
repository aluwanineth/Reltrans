import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { DxTreeViewComponent } from 'devextreme-angular';
import { ValidationCallbackData } from 'devextreme/common';
import notify from 'devextreme/ui/notify';
import { first } from 'rxjs';
import { Customer } from 'src/app/shared/models/customer.model';
import { AuthService } from 'src/app/shared/services';

@Component({
  selector: 'app-customer-register',
  templateUrl: './customer-register.component.html',
  styleUrls: ['./customer-register.component.scss']
})
export class CustomerRegisterComponent implements OnInit{
  @ViewChild(DxTreeViewComponent, { static: false }) treeView: any;
  companyName: string = '';
  contactTelNo: string = '';
  loading = false;
  formData: any = {};
  treeDataSource: any;
  treeBoxValue: string[] = [];
  gridDataSource: any;
  gridBoxValue: number[] = [3];
  memberTypes: string[] = [];
  currentUser: Customer | null = { email: '',firstName: '',surname:'', accNo: '', companyName:'',contactTelNo:'', memberType: [] };
  
 
  constructor(private router: Router,
    private authService: AuthService){
      this.authService.user.subscribe(x => this.currentUser = x);
      this.treeDataSource = 
        [
          {
            "ID": 1,
            "name": "Accountant",
            "expanded": true
          },
          {
            "ID": 2,
            "name": "Project Manager",
            "expanded": true
          },
          {
            "ID": 3,
            "name": "Buyer",
            "expanded": true
          },
          
        ];
      this.treeBoxValue = ['1_1'];
      if (this.currentUser) {
        this.companyName =  this.currentUser.companyName; 
        this.contactTelNo = this.currentUser.contactTelNo;
      }
    }

  ngOnInit(): void {

  }

  async onSubmit(e: Event) {
    e.preventDefault();
    //const {firstName, surname, companyName, contactTelNo, email, password } = this.formData;
    let model = {
      "firstName": this.formData.firstName,
      "surname": this.formData.surname,
      "accNo": this.companyName,
      "companyName": this.companyName,
      "contactTelNo": this.contactTelNo,
      "memberType": this.memberTypes,
      "email": this.formData.email,
      "password": this.formData.password,
      "confirmPassword": this.formData.confirmedPassword
    };
    console.log(JSON.stringify(model));
    this.loading = true;
    this.authService.registerCustomer(model)
        .pipe(first())
        .subscribe(
            data => {
              notify({
                message: data.result.message,
                position: {
                    my: 'center top',
                    at: 'center top'
                }
              }, 'success', 5000);
              this.router.navigate(['/user-data']);
            },
            error => {
              notify({ message: error, width: 300, shading: true }, 'error', 5000);
            }
        );
    this.loading = false;
  }
  confirmPassword = (e: ValidationCallbackData) => {
    return e.value === this.formData.password;
  }

  onDropDownBoxValueChanged(e: any) {
    const ids = e.value;
    ids.forEach((id: any) => {
      const matchingItem = this.treeDataSource.find((item: { ID: any; }) => item.ID === id);
      if (matchingItem) {
        this.memberTypes.push(matchingItem.name);
      }
    });
    console.log(this.memberTypes);
    this.updateSelection(this.treeView && this.treeView.instance);
    
  }

  onTreeViewReady(e: any) {
    this.updateSelection(e.component);
  }

  updateSelection(treeView: any) {
    if (!treeView) return;

    if (!this.treeBoxValue) {
      treeView.unselectAll();
    }

    if (this.treeBoxValue) {
      this.treeBoxValue.forEach(((value) => {
        treeView.selectItem(value);
      }));
    }
  }

  onTreeViewSelectionChanged(e: any) {
    this.treeBoxValue = e.component.getSelectedNodeKeys();
    console.log(this.treeBoxValue);
  }

  getNameById(id: number): string | undefined {
    const item = this.treeDataSource.find((entry: { ID: number; }) => entry.ID === id);
    return item ? item.name : undefined;
  }
}
