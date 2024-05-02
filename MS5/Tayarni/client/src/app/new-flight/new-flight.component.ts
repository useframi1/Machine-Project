import { Component, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import {
  BsDatepickerConfig,
  BsDatepickerDirective,
} from 'ngx-bootstrap/datepicker';
import { AccountService } from '../_services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-flight',
  templateUrl: './new-flight.component.html',
  styleUrls: ['./new-flight.component.css'],
})
export class NewFlightComponent implements OnInit, AfterViewInit {
  model: any = {};
  airports: any;
  airlines: any;
  tailNums: any;

  colorTheme = 'theme-blue';

  @ViewChild('dp') dp!: BsDatepickerDirective;

  constructor(private accountService: AccountService, private router: Router) {}

  ngOnInit(): void {
    this.airports = ['airport1', 'airport2', 'airport3'];
    this.airlines = ['airline1', 'airline2', 'airline3'];
    this.tailNums = ['tailNum1', 'tailNum2', 'tailNum3'];
  }

  bsConfig?: Partial<BsDatepickerConfig>;

  ngAfterViewInit(): void {
    setTimeout(() => {
      this.applyTheme();
    });
  }

  applyTheme() {
    this.bsConfig = Object.assign(
      {},
      { containerClass: this.colorTheme, dateInputFormat: 'YYYY-MM-DD' }
    );
  }

  save() {
    console.log(this.model);
  }
}
