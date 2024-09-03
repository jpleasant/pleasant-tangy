import {StyleSheet, View, Text, FlatList} from "react-native";
import {ThemedText} from "@/components/ThemedText";
import {useEffect, useState} from "react";
import {getShortDate} from "@/utils/dateUtils";
import {Link} from "expo-router";
import FamilyEventRpc from "@/views/FamilyCalendar/FamilyEventRpc";
import {ThemedView} from "@/components/ThemedView";
import {Colors} from "@/constants/Colors";
import TextTag from "@/components/TextTag";
import {setState} from "jest-circus";

export default function FamilyCalendarView({}){
   const familyEvents: FamilyEvent = FamilyEventRpc();
    const [dates, setDates] = useState<FamilyEventDetail[]>([]);
   const [pressed, setPress] = useState(false);
    useEffect(()=>{
        const getDates = async()=> {
            const dates = await familyEvents.getAllFamilyEvents();
            setDates(dates);    
        }
        getDates();
        
        
    }, [dates])
    
    const handlePress = ()=>{
        setPress(true);
    }
    type itemProp = {name:string, date:Date}
    const DateItem = ({name, date}:itemProp)=>(
        <View style={styles.dateItem}>
            <Link suppressHighlighting={true} href={{pathname: "/family-calendar-detail", params:{name:name} }} >
                <ThemedText>{name}</ThemedText>                 
            </Link>
            <TextTag>{getShortDate(date)}</TextTag>
        </View>
    )
    return(
        
        <ThemedView style={styles.container}>
            <ThemedText type={'title'} style={styles.title}>Family Calendar</ThemedText>
                <FlatList data={dates} renderItem={(item)=> <DateItem name={item.item.name} date={item.item.start} />} 
                />
            
        </ThemedView>
    )
}

const styles = StyleSheet.create({
    container:{
        height:'100%',
        //backgroundColor: "white"
    },
    title: {
        textAlign:"center",
        marginTop:"10%",
        marginBottom:"5%"
    },
    dateItem:{
      display:"flex",
      flexDirection:"row",
      justifyContent:"space-between", 
      alignItems:"center",
      paddingLeft: 20,  
      paddingTop:"2%", 
      paddingBottom: 10,
      borderBottomWidth:.2
    },
    spacer:{
        width:20
    },
    
    stepContainer: {
        gap: 8,
        marginBottom: 8,
    },
    activeLink: {
        opacity: 1
    }

});