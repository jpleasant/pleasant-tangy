import {LocalFamilyEvent} from "@/features/FamilyEvents/LocalFamilyEvent";

export enum FEATURES {
    FAMILY_EVENT
}
const featureCollection = new Map();
function addFeature<T>(name:FEATURES, service: T, ): asserts service is NonNullable<T>{
    featureCollection.set(name, service);
}

function create<T>(feature:FEATURES): T{
    return featureCollection.get(feature);
}
export function FeatureFactory(){
    addFeature<FamilyEvent>(FEATURES.FAMILY_EVENT, LocalFamilyEvent());
    
    return {create: create}
} 