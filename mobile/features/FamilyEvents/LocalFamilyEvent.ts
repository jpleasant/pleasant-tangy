import {familyEventTestData} from "@/features/FamilyEvents/familyEventTestData";

export function LocalFamilyEvent():FamilyEvent {
    
    return {
        getAllFamilyEvents:()=>{
            return Promise.resolve(familyEventTestData);
        }
    }
}