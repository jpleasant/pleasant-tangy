import {View, Text, StyleSheet} from "react-native";
import {NativeStackScreenProps} from "@react-navigation/native-stack";

export default function KeyDateDetail(props:{name:string}){
    
    return(
        <View style={styles.container}>
            <Text>{props.name}</Text>
        </View>
    )
}

const styles= StyleSheet.create({
    container:{
        backgroundColor:"#FFFFFF",
        height:"100%"
    }
})