import CalendarDetailView from "@/views/FamilyCalendar/CalendarDetailView";
import {useLocalSearchParams, useNavigation} from "expo-router";


export default function FamilyCalendarDetail(){
    const local = useLocalSearchParams<{name:string}>();
    const navigation = useNavigation();
    navigation.setOptions({title:"Detail", headerBackTitle:"Family Calendar"})
    return(
        <CalendarDetailView name={local.name ?? ""}></CalendarDetailView>
    )
}

