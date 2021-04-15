import { Component, OnInit } from "@angular/core";
import { ComputerData } from "../services/computerdata";
import { ComputerInfo } from "../services/ComputerInfo";

@Component({
  selector: "computer-list",
  templateUrl: "computerListView.html"
})
export default class ComputerListView implements OnInit{

  public computers: ComputerInfo[];
    constructor(public data: ComputerData) {
  }

  ngOnInit(): void {
    this.data.loadComputers()
    .subscribe();
  }

}


