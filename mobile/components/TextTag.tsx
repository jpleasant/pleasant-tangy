import {Colors} from "@/constants/Colors";
import React from "react";
import {View, Text, ViewProps} from "react-native";
import {useThemeColor} from "@/hooks/useThemeColor";


export default function TextTag(props:ViewProps){
    const backgroundColor = useThemeColor({ light: Colors.light.backgroundAlt, dark: Colors.dark.backgroundAlt }, 'background');
    const textColor = useThemeColor({ light: Colors.light.textAlt, dark: Colors.dark.textAlt }, "text");
    const style = {
        itemTag:{
            textAlign:"left",
            marginRight:35,
            padding:5,
            backgroundColor: backgroundColor,
            borderWidth: 1,
            borderRadius: 20,
            borderColor: Colors.light.tabIconDefault,
            color:textColor,
            fontWeight:"bold"
        },
        innerText: {
            color:textColor
        }
    }
    
    return(
        <View style={style.itemTag}>
            <Text style={style.innerText}>{props.children}</Text>
        </View>
    )
}