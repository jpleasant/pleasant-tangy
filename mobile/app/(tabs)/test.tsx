import { Text, StyleSheet } from 'react-native';

export default function Page() {
    return <Text style={styles.main}>Top-level page</Text>;
}

const styles = StyleSheet.create({
    main:{
        backgroundColor:"white",
        color:"black"    
    }
    
})