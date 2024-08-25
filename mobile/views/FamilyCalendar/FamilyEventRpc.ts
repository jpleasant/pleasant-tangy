import {familyEventTestData} from "@/views/FamilyCalendar/familyEventTestData";

export default function FamilyEventRpc():FamilyEvent {
    return {
        getAllFamilyEvents: () => {
            return Promise.resolve(familyEventTestData);
        }
    }
}