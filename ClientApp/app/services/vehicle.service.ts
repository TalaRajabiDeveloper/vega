﻿import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class VehicleService {
    private vehiclesEndpoint = '/api/vehicles';

    constructor(private http: Http) {
        
    }

    getFeatures() {
        return this.http.get('/api/features')
            .map(res => res.json());
    }

    getMakes() {
        return this.http.get('/api/makes')
            .map(res => res.json());
    }

    getModels() {
        return this.http.get('/api/models')
            .map(res => res.json());
    }
}

 