import KeyDateDetail from "@/features/FamilyEvents/KeyDateDetail";
import {useLocalSearchParams, useNavigation} from "expo-router";


export default function KeyDateDetailPage(){
    const local = useLocalSearchParams<{name:string}>();
    const navigation = useNavigation();
    navigation.setOptions({title:"Detail", headerBackTitle:"Key Dates"})
    return(
        <KeyDateDetail name={local.name ?? ""}></KeyDateDetail>
    )
}

