import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPanelComponent } from './Admin/admin-panel/admin-panel.component';
import { KarticeComponent } from './kartice/kartice.component';
import { KontaktComponent } from './kontakt/kontakt.component';
import { StanoviDetailComponent } from './stanovi/stanovi-detail/stanovi-detail.component';
import { StanoviListComponent } from './stanovi/stanovi-list/stanovi-list.component';
import { TablicaComponent } from './tablica/tablica.component';
import { AdminGuard } from './_guard/admin.guard';
import { AuthGuard } from './_guard/auth.guard';

const routes: Routes = [
    
  {path: '', component: KarticeComponent},
  {path: 'tablica', component: TablicaComponent, canActivate:[AuthGuard]},
  {path: 'kontakt', component: KontaktComponent, canActivate:[AuthGuard]},
  {path: 'stanovi', component: StanoviListComponent},
  {path: 'stanovi/:id', component: StanoviDetailComponent},
  {path: 'admin', component: AdminPanelComponent, canActivate: [AdminGuard]}
  

];
@NgModule({
imports: [RouterModule.forRoot(routes)],
exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [KarticeComponent,TablicaComponent,KontaktComponent]
