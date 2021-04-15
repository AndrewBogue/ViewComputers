import { Component, OnInit } from "@angular/core";
import { ComputerData } from "../services/computerdata";
import { ComputerInfo } from "../services/ComputerInfo";

@Component({
  selector: "computer-list",
  templateUrl: "computerListView.html"
})
export default class ComputerListView implements OnInit{

  elements: any = [];
  headElements = ['processor', 'ram', 'Last', 'Handle'];
  searchText: string = '';
  previous: string;
  public computers: ComputerInfo[];
    constructor(public data: ComputerData) {
  }

  ngOnInit(): void {
    this.data.loadComputers()
    .subscribe();
  }

  searchItems() {
    const prev = this.computers.getDataSource();
    if (!this.searchText) {
      this.computers.setDataSource(this.previous);
      this.elements = this.computers.getDataSource();
    }
    if (this.searchText) {
      this.elements = this.computers.searchLocalDataBy(this.searchText);
      this.computers.setDataSource(prev);
    }
  }
}


