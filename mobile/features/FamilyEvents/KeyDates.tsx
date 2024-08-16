import {StyleSheet, View, Text, FlatList} from "react-native";
import {ThemedText} from "@/components/ThemedText";
import {FeatureFactory, FEATURES} from "@/factories/FeatureFactory";
import {useEffect, useState} from "react";
import {getShortDate} from "@/utils/dateUtils";
import {Link} from "expo-router";

export default function KeyDatesView({}){
    const [dates, setDates] = useState<FamilyEventDetail[]>([]);
    const factory = FeatureFactory();
    const familyEvent = factory.create<FamilyEvent>(FEATURES.FAMILY_EVENT);
    useEffect(()=>{
        const getDates = async()=> {
            const dates = await familyEvent.getAllFamilyEvents();
            setDates(dates);    
        }
        getDates();
    }, [dates])
    
    type itemProp = {name:string, date:Date}
    const DateItem = ({name, date}:itemProp)=>(
        <View style={styles.dateItem}>
            <Link href={{pathname: "/keyDateDetailPage", params:{name:name} }} >
                <Text>{name} - </Text>
                <Text>{getShortDate(date)}</Text>    
            </Link>
            
        </View>
    )
    return(
        
        <View style={styles.container}>
            <ThemedText type={'title'} style={styles.title}>Key Dates</ThemedText>
                <FlatList data={dates} renderItem={(item)=> <DateItem name={item.item.name} date={item.item.start} />} 
                />
            
        </View>
    )
}

const styles = StyleSheet.create({
    container:{
        height:'100%',
        backgroundColor: "white"
    },
    title: {
        textAlign:"center",
        marginTop:"20%",
        marginBottom:"5%"
    },
    dateItem:{
      display:"flex",
      flexDirection:"row",
      justifyContent:"center",
      paddingTop:"2%"  
    },
    stepContainer: {
        gap: 8,
        marginBottom: 8,
    },

});