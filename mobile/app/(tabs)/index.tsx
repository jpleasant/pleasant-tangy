import {Image, StyleSheet, Platform} from 'react-native';
import {View, Text} from 'react-native-ui-lib';
export default function HomeScreen() {
  return (
    <View backgroundColor={"white"} style={styles.container}>
        <Text center marginT-70 text50 black>Key Dates</Text>
    </View>
  );
}

const styles = StyleSheet.create({
  container:{
    height:'100%'
  },
  titleContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    gap: 8,
  },
  stepContainer: {
    gap: 8,
    marginBottom: 8,
  },
  reactLogo: {
    height: 178,
    width: 290,
    bottom: 0,
    left: 0,
    position: 'absolute',
  },
});
