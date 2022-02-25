import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { AdminPanelComponent } from './Admin/admin-panel/admin-panel.component';
import { PhotoManagementComponent } from './Admin/photo-management/photo-management.component';
import { UserManagementComponent } from './Admin/user-management/user-management.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { KarticeComponent } from './kartice/kartice.component';
import { KontaktComponent } from './kontakt/kontakt.component';
import { NavigacijaComponent } from './navigacija/navigacija.component';
import { RegisterComponent } from './register/register.component';
import { StanoviDetailComponent } from './stanovi/stanovi-detail/stanovi-detail.component';
import { StanoviListComponent } from './stanovi/stanovi-list/stanovi-list.component';
import { TablicaComponent } from './tablica/tablica.component';
import { HasRoleDirective } from './_directives/has-role.directive';
import {LayoutModule} from '@angular/cdk/layout';
import {MatListModule} from '@angular/material/list';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatSortModule} from '@angular/material/sort';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalModule } from 'ngx-bootstrap/modal';
import { RolesModalComponent } from './Modals/roles-modal/roles-modal.component';


@NgModule({
  declarations: [
    AppComponent,
    NavigacijaComponent,
    TablicaComponent,
    KarticeComponent,
    KontaktComponent,
    RegisterComponent,
    StanoviListComponent,
    StanoviDetailComponent,
    AdminPanelComponent,
    HasRoleDirective,
    UserManagementComponent,
    PhotoManagementComponent,
    RolesModalComponent,
    
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    AppRoutingModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    HttpClientModule,
    BsDropdownModule.forRoot(),
    ToastrModule.forRoot({
      positionClass: "toast-bottom-right"
    }),
    TabsModule,
    NgbModule,
    ModalModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
