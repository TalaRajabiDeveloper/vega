import { Component,OnInit } from '@angular/core';
import { VehicleService } from '../../services/vehicle.service';


@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html',
    styleUrls: ['./vehicle-form.component.css'],
    providers: [VehicleService]
})
export class VehicleFormComponent implements OnInit {
    features;
    makes;
    models;
    selectedModels;

    constructor(private vehicleService : VehicleService) {
       
    }

    ngOnInit(): void {
        this.populatedropdowns();
    }

    populateModel(id:any) {
        this.selectedModels = this.models.filter(function (item: any) {
            let isValid = (item.makeId == id);
            return isValid;
        });
    }


    populatedropdowns() {
        this.vehicleService.getModels().subscribe(m => {
            this.models = m;
        });

        this.vehicleService.getMakes().subscribe(m => {
            this.makes = m;
        });

         this.vehicleService.getFeatures().subscribe(f => {
             this.features = f;
         });
    }


}
