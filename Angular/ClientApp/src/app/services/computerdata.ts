import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { ComputerInfo } from "./ComputerInfo";

@Injectable()
export class ComputerData {

  constructor(private http: HttpClient) { }
  public computers: ComputerInfo[];
   
  loadComputers() {
    return this.http.get<[]>("/api/computers")
      .pipe(map(data => {
        this.computers = data;
        return;
      }));
  }
}
