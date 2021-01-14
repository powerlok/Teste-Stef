import { Routes } from "@angular/router";
import { PessoaEditarComponent } from 'src/app/pages/pessoa-editar/pessoa-editar.component';
import { PessoaComponent } from 'src/app/pages/pessoa/pessoa.component';

import { DashboardComponent } from "../../pages/dashboard/dashboard.component";
import { IconsComponent } from "../../pages/icons/icons.component";
import { MapComponent } from "../../pages/map/map.component";
import { NotificationsComponent } from "../../pages/notifications/notifications.component";
import { TablesComponent } from "../../pages/tables/tables.component";
import { TypographyComponent } from "../../pages/typography/typography.component";

export const AdminLayoutRoutes: Routes = [
  { path: "dashboard", component: DashboardComponent },
  { path: "icons", component: IconsComponent },
  { path: "maps", component: MapComponent },
  { path: "notifications", component: NotificationsComponent },
  { path: "pessoa", component: PessoaComponent },
  { path: "pessoa-editar/:id", component: PessoaEditarComponent },
  { path: "tables", component: TablesComponent },
  { path: "typography", component: TypographyComponent },
];
