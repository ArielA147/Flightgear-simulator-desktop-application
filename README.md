# Flightgear simulator desktop application

## Discription 
 Creating a remote control for FlightGear Simulator which allow the user to connect and disconnect to simulator and sending commands. 

## Prerequisites
### Configuration set-up:
#### Env.requirements :
* Download the simulator from : http://home.flightgear.org/
* Confing setting of the flightgear simulator :
```
--generic=socket,out,10,127.0.0.1,5400,tcp,generic_small
--telnet=socket,in,10,127.0.0.1,5402,tcp
```
* upload the generic_small.xml file your path : 
```
[file of the flightgear app on our comupter] \data\Protocol
```
<img width="412" alt="simulator setting screen" src="https://user-images.githubusercontent.com/43312651/56731888-4562bc80-6764-11e9-9d34-1475ba381816.PNG">

## About the application
 This project enable you to control the flying commands simulator and get info of the flight path simulator.
 Inorder to connect to the simulator - click on "Setting" button and check if the communication deatils are correct , if they are updated click on the "Connect" button.

<img width="516" alt="simulator screen" src="https://user-images.githubusercontent.com/43312651/56731142-6a563000-6762-11e9-9526-31ca4125ea49.PNG">

 now the run the flight simulator - run the .exe file of the filghtgear simulation you have been downloaded and press on "fly" button.

<img width="463" alt="start screen after connection" src="https://user-images.githubusercontent.com/43312651/56730965-f4ea5f80-6761-11e9-9fd8-a06ee2ab8786.PNG">

### Fying plane
  in simulator press on "Autostart" for warming the engieen, afterwards you have to push the throtle . 
  you can do it thoghout the simulator or throgh my application . 
  In the App you can choose how to send the commands - by manual or by auto pilot.
  
  * by manual : 
  
  <img width="550" alt="insert trothel" src="https://user-images.githubusercontent.com/43312651/56731489-3d564d00-6763-11e9-8dfc-d893bef9ff64.PNG">

  * by auto pilot , after typing the commands - press the send in order to send the simulator commands. 
  #### in order to see the possible set commands you can check the attache xml file : generic_small.xml
  
  
  <img width="500" alt="changing the throttle by auto command" src="https://user-images.githubusercontent.com/43312651/56731505-4d6e2c80-6763-11e9-8d00-799bdc30e6ee.PNG">
  
  screen after sending the command : 
  
  <img width="500" alt="update command of throttle" src="https://user-images.githubusercontent.com/43312651/56732093-f10c0c80-6764-11e9-967f-c118e5b7d51b.PNG">
  
  on the right side of the app you can see the path of the plane while you flying the aircraft.
  <img width="461" alt="flightboard screen" src="https://user-images.githubusercontent.com/43312651/56732430-f7e74f00-6765-11e9-8304-c242046c813e.png">
  
  Now fly the plane with the joystick and try not to crash.
  
  <img width="521" alt="flying the simulator" src="https://user-images.githubusercontent.com/43312651/56732447-09305b80-6766-11e9-839f-28c61d763b36.PNG">
