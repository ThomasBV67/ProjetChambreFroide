EESchema Schematic File Version 4
EELAYER 30 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 2 3
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
Text GLabel 5650 2700 0    50   Input ~ 0
5V
Text GLabel 4850 2800 2    50   Input ~ 0
3V3
$Comp
L Device:D_Schottky D?
U 1 1 600862AB
P 4850 2950
AR Path="/600862AB" Ref="D?"  Part="1" 
AR Path="/60082C21/600862AB" Ref="D202"  Part="1" 
F 0 "D202" V 4800 2700 50  0000 L CNN
F 1 "D_Schottky" V 4700 2500 50  0000 L CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 4850 2950 50  0001 C CNN
F 3 "~" H 4850 2950 50  0001 C CNN
	1    4850 2950
	0    1    1    0   
$EndComp
Text GLabel 2850 3200 2    50   Input ~ 0
5V
Wire Wire Line
	5750 2800 5650 2800
Wire Wire Line
	5650 2800 5550 2800
Connection ~ 5650 2800
Wire Wire Line
	5650 2700 5650 2800
$Comp
L Interface_USB:FT232RL U?
U 1 1 600862B8
P 5650 3800
AR Path="/600862B8" Ref="U?"  Part="1" 
AR Path="/60082C21/600862B8" Ref="U201"  Part="1" 
F 0 "U201" H 6000 4850 50  0000 C CNN
F 1 "FT232RL" H 6000 4750 50  0000 C CNN
F 2 "Package_SO:SSOP-28_5.3x10.2mm_P0.65mm" H 6750 2900 50  0001 C CNN
F 3 "https://www.ftdichip.com/Support/Documents/DataSheets/ICs/DS_FT232R.pdf" H 5650 3800 50  0001 C CNN
	1    5650 3800
	1    0    0    -1  
$EndComp
Wire Wire Line
	2550 3800 2550 3600
$Comp
L power:GND #PWR?
U 1 1 600862BF
P 2150 3800
AR Path="/600862BF" Ref="#PWR?"  Part="1" 
AR Path="/60082C21/600862BF" Ref="#PWR0201"  Part="1" 
F 0 "#PWR0201" H 2150 3550 50  0001 C CNN
F 1 "GND" H 2155 3627 50  0000 C CNN
F 2 "" H 2150 3800 50  0001 C CNN
F 3 "" H 2150 3800 50  0001 C CNN
	1    2150 3800
	1    0    0    -1  
$EndComp
$Comp
L Device:D_Schottky D?
U 1 1 600862C5
P 2700 3200
AR Path="/600862C5" Ref="D?"  Part="1" 
AR Path="/60082C21/600862C5" Ref="D201"  Part="1" 
F 0 "D201" H 2700 2983 50  0000 C CNN
F 1 "D_Schottky" H 2700 3074 50  0000 C CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 2700 3200 50  0001 C CNN
F 3 "~" H 2700 3200 50  0001 C CNN
	1    2700 3200
	-1   0    0    1   
$EndComp
Connection ~ 2150 3800
Wire Wire Line
	2250 3800 2550 3800
Wire Wire Line
	2150 3800 2250 3800
Connection ~ 2250 3800
$Comp
L Module-Central-rescue:USB_B_Mini-Connector J?
U 1 1 600862CF
P 2250 3400
AR Path="/600862CF" Ref="J?"  Part="1" 
AR Path="/60082C21/600862CF" Ref="J201"  Part="1" 
F 0 "J201" H 2307 3867 50  0000 C CNN
F 1 "USB_B_Mini" H 2307 3776 50  0000 C CNN
F 2 "Connector_USB:USB_Mini-B_Lumberg_2486_01_Horizontal" H 2400 3350 50  0001 C CNN
F 3 "~" H 2400 3350 50  0001 C CNN
	1    2250 3400
	1    0    0    -1  
$EndComp
$Comp
L Device:LED D204
U 1 1 60088A46
P 7000 4750
F 0 "D204" V 6947 4830 50  0000 L CNN
F 1 "TX" V 7038 4830 50  0000 L CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 7000 4750 50  0001 C CNN
F 3 "~" H 7000 4750 50  0001 C CNN
	1    7000 4750
	0    1    1    0   
$EndComp
$Comp
L Device:LED D203
U 1 1 60089150
P 6750 4750
F 0 "D203" V 6697 4830 50  0000 L CNN
F 1 "RX" V 6788 4830 50  0000 L CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 6750 4750 50  0001 C CNN
F 3 "~" H 6750 4750 50  0001 C CNN
	1    6750 4750
	0    1    1    0   
$EndComp
Wire Wire Line
	6750 4600 6750 4100
Wire Wire Line
	6750 4100 6450 4100
Wire Wire Line
	7000 4600 7000 4200
Wire Wire Line
	7000 4200 6450 4200
$Comp
L Device:R R204
U 1 1 60089929
P 6750 5050
F 0 "R204" H 6820 5096 50  0000 L CNN
F 1 "330" H 6820 5005 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 6680 5050 50  0001 C CNN
F 3 "~" H 6750 5050 50  0001 C CNN
	1    6750 5050
	1    0    0    -1  
$EndComp
$Comp
L Device:R R205
U 1 1 60089DDB
P 7000 5050
F 0 "R205" H 7070 5096 50  0000 L CNN
F 1 "330" H 7070 5005 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 6930 5050 50  0001 C CNN
F 3 "~" H 7000 5050 50  0001 C CNN
	1    7000 5050
	1    0    0    -1  
$EndComp
Wire Wire Line
	7000 5200 6750 5200
Text GLabel 6850 5200 3    50   Input ~ 0
5V
$Comp
L power:GND #PWR0203
U 1 1 6008A54D
P 5750 4800
F 0 "#PWR0203" H 5750 4550 50  0001 C CNN
F 1 "GND" H 5755 4627 50  0000 C CNN
F 2 "" H 5750 4800 50  0001 C CNN
F 3 "" H 5750 4800 50  0001 C CNN
	1    5750 4800
	1    0    0    -1  
$EndComp
Wire Wire Line
	5850 4800 5750 4800
Connection ~ 5650 4800
Wire Wire Line
	5650 4800 5450 4800
Connection ~ 5750 4800
Wire Wire Line
	5750 4800 5650 4800
NoConn ~ 6450 3300
NoConn ~ 6450 3400
NoConn ~ 6450 3600
NoConn ~ 6450 3700
NoConn ~ 6450 3800
$Comp
L Device:C C203
U 1 1 6008B005
P 6600 3500
F 0 "C203" V 6450 3500 50  0000 C CNN
F 1 "0.1" V 6750 3550 50  0000 C CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 6638 3350 50  0001 C CNN
F 3 "~" H 6600 3500 50  0001 C CNN
	1    6600 3500
	0    1    1    0   
$EndComp
NoConn ~ 6450 4300
NoConn ~ 6450 4400
NoConn ~ 6450 4500
NoConn ~ 4850 4500
NoConn ~ 4850 4200
NoConn ~ 4850 4000
NoConn ~ 4850 3800
$Comp
L Device:R R203
U 1 1 6008C3B2
P 6600 3100
F 0 "R203" V 6393 3100 50  0000 C CNN
F 1 "10" V 6484 3100 50  0000 C CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 6530 3100 50  0001 C CNN
F 3 "~" H 6600 3100 50  0001 C CNN
	1    6600 3100
	0    1    1    0   
$EndComp
Text GLabel 6750 3100 2    50   Input ~ 0
RX
Text GLabel 6450 3200 2    50   Input ~ 0
TX
Text GLabel 7300 3500 2    50   Input ~ 0
DTR
Text Notes 4150 2450 0    50   ~ 0
Section facultative\nSection utilisée uniquement pour prototypage, permet un changement de programme plus facile.
$Comp
L power:PWR_FLAG #FLG0201
U 1 1 600CD3F1
P 7500 2750
F 0 "#FLG0201" H 7500 2825 50  0001 C CNN
F 1 "PWR_FLAG" H 7500 2923 50  0000 C CNN
F 2 "" H 7500 2750 50  0001 C CNN
F 3 "~" H 7500 2750 50  0001 C CNN
	1    7500 2750
	1    0    0    -1  
$EndComp
Text GLabel 7500 2750 3    50   Input ~ 0
5V
$Comp
L Device:R R?
U 1 1 60372200
P 7150 3350
F 0 "R?" H 7220 3396 50  0000 L CNN
F 1 "10K" H 7220 3305 50  0000 L CNN
F 2 "" V 7080 3350 50  0001 C CNN
F 3 "~" H 7150 3350 50  0001 C CNN
	1    7150 3350
	1    0    0    -1  
$EndComp
Wire Wire Line
	6750 3500 7150 3500
Connection ~ 7150 3500
Wire Wire Line
	7150 3500 7300 3500
Text GLabel 7150 3200 1    50   Input ~ 0
5V
Wire Wire Line
	2550 3400 4850 3400
Wire Wire Line
	2550 3500 4850 3500
$EndSCHEMATC
