import {Colors} from "@/constants/Colors";
import React from "react";
import {View, Text, ViewProps} from "react-native";


export default function TextTag(props:ViewProps){
    
    const style = {
        itemTag:{
            textAlign:"left",
            marginRight:35,
            padding:5,
            backgroundColor: Colors.light.icon,
            borderWidth: 1,
            borderRadius: 20,
            borderColor: Colors.light.tabIconDefault,
            color:"#FFFFFF"
        },
        innerText: {
            color:"#FFFFFF"
        }
    }
    
    return(
        <View style={style.itemTag}>
            <Text style={style.innerText}>{props.children}</Text>
        </View>
    )
}