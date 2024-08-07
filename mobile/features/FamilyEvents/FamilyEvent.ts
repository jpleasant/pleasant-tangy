interface FamilyEvent {
    getAllFamilyEvents:()=>Promise<FamilyEventDetail[]>
}

type FamilyEventDetail = {
    eventType: 'Birthday' | 'Anniversary' | 'Trip' | 'Special',
    name:string,
    start:Date,
    end?:Date,
    details?:string,
    reminder:boolean,
    reminderLength:number,
    reminderFrequency:number
}