import {View, Text, StyleSheet} from "react-native";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {ThemedView} from "@/components/ThemedView";

export default function CalendarDetailView(props:{name:string}){
    
    return(
        <ThemedView style={styles.container}>
            <Text>{props.name}</Text>
        </ThemedView>
    )
}

const styles= StyleSheet.create({
    container:{
        //backgroundColor:"#FFFFFF",
        height:"100%"
    }
})