import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import notify from 'devextreme/ui/notify';
import { first } from 'rxjs';
import { Customer } from 'src/app/shared/models/customer.model';
import { AuthService } from 'src/app/shared/services';
import { DesignGAService } from 'src/app/shared/services/design.ga.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-customer-ga',
  templateUrl: './customer-ga.component.html',
  styleUrls: ['./customer-ga.component.scss']
})
export class CustomerGaComponent implements OnInit{
  currentUser: Customer | null = { email: '',firstName: '',surname:'', accNo: '', companyName:'',contactTelNo:'', memberType: [] };
  accNo: string = '';
  dataSource: any;
  loadingVisible: boolean = false;
  isDropZoneActive = false;
  data: any = ['Pending', 'Signed', 'Approved'];
  imageSource = '';
  uploadUrl: string = '';
  value: any[] = [];
  statusData: string[] = [];
  statusLabel = '';
  valueChange = false;
  userEmail: string = ''; 
  textVisible = true;
  notes: string = 'notes';
  progressVisible = false;
  selectedData: any;

  progressValue = 0;
  popupVisible = false;

  constructor(private router: Router, private designGAService: DesignGAService,
    private authService: AuthService) {
    this.authService.user.subscribe(x => this.currentUser = x);
    if (this.currentUser) {
      this.accNo =  this.currentUser.accNo;
      this.userEmail = this.currentUser.email;
    }
    this.onDropZoneEnter = this.onDropZoneEnter.bind(this);
    this.onDropZoneLeave = this.onDropZoneLeave.bind(this);
    this.onUploaded = this.onUploaded.bind(this);
    this.onProgress = this.onProgress.bind(this);
    this.onUploadStarted = this.onUploadStarted.bind(this);
    this.downloadOnClick = this.downloadOnClick.bind(this);
    this.viewUploadForm = this.viewUploadForm.bind(this);
  }

  ngOnInit(): void {
    this.loadData();
    this.uploadUrl = `${environment.apiUrl}/api/v1.0/DesignGA/uploa`;
    this.statusData = [
      'Pending',
      'Signed',
      'Edited',
      'Approved',
      'Not Approved'
   ];
  }

  loadData() {
    this.designGAService.getDesignGAByAccNo(this.accNo)
    .subscribe( data => {
      this.dataSource = data.result;
      console.log(this.dataSource);
    },
    error => {
      this.loadingVisible = false;
      notify({ message: error.error.Message, width: 300, shading: true }, 'error', 5000);
    });
  }

  onDropZoneEnter(e: any) {
    if (e.dropZoneElement.id === 'dropzone-external') { this.isDropZoneActive = true; }
  }

  onDropZoneLeave(e: any) {
    if (e.dropZoneElement.id === 'dropzone-external') { this.isDropZoneActive = false; }
  }

  onUploaded(e: any) {
    const file = e.file;
    const fileReader = new FileReader();
    fileReader.onload = () => {
      this.isDropZoneActive = false;
      this.imageSource = fileReader.result as string;
    };
    fileReader.readAsDataURL(file);
    this.textVisible = false;
    this.progressVisible = false;
    this.progressValue = 0;
  }

  onProgress(e: any) {
    this.progressValue = e.bytesLoaded / e.bytesTotal * 100;
  }

  onUploadStarted(e: any) {
    this.imageSource = '';
    this.progressVisible = true;
    console.log(e);
  }

  downloadOnClick(e: any) {
    const id =  e.row.data.recid;
    this.designGAService.downloadFile(id);
    
  }

  public uploadFile = (files: string | any[]) => {
    if (files.length === 0) {
      Swal.fire(
        '',
        'Please select pdf file to upload.',
        'error'
      );
      return;
    }
    if (!this.valueChange) {
      Swal.fire(
        '',
        'Please select file status.',
        'error'
      );
      return;
    }
    const data =  this.selectedData;
    console.log(this.selectedData);
    //update 
    const designGA = {
      "recid": data.recid,
      "jobNo": data.jobNo,
      "accNo": data.accNo,
      "specNo": data.specNo,
      "revNo": data.revNo,
      "docName": data.docName,
      "status": this.statusLabel,
      "fileLocation": data.fileLocation
    };
    this.updateGa(designGA);
    const startDate: Date = new Date();
    
    const fdate = startDate.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
    //add history
    const designGAHistory = {
      "gaId": data.recid,
      "eventDate": startDate,
      "eventType": 'Upload file',
      "notes": this.notes,
      "sender": this.userEmail,
      "recipient": '',
      "copied": '',
      "message": ''
    }
    this.addGaHistory(designGAHistory);
    this.loadingVisible = true;

    const fileToUpload =  files[0] as File;
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    
    this.designGAService.uploadFile(formData, data.recid)
    .pipe(first())
    .subscribe(result => {
      this.loadingVisible = false;
      this.value = [];
      Swal.fire(
        '',
        'Successfully uploaded file',
        'success'
      );
    }, error => {
      console.log(error);
     // notify({ message: error, width: 300, shading: true }, 'error', 5000);
      // Swal.fire(
      //   '',
      //   'Error occur while uploading a file',
      //   'error'
      // );
      this.loadingVisible = false;
    });
  }

  onValueChanged(event: any) {
    this.valueChange = true;
    this.statusLabel = event.value;
  }

  viewUploadForm(e : any) {
    this.selectedData = e.row.data;
    this.popupVisible = true;
  }

  updateGa(designGA : any){
    this.designGAService.update(designGA)
    .pipe(first())
    .subscribe(result => {
    }, error => {
      console.log(error);
       notify({ message: 'Erorr occurs while updating GA', width: 300, shading: true }, 'error', 5000);
    });
  }

  addGaHistory(designGAHistory : any){
    this.designGAService.addDesignGAHistory(designGAHistory)
    .pipe(first())
    .subscribe(result => {
    }, error => {
      console.log(error);
       notify({ message: 'Erorr occurs while adding GA', width: 300, shading: true }, 'error', 5000);
    });
  }

  onTextValueChanged(e: any){
    console.log(e);
  }
}