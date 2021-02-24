EESchema Schematic File Version 4
EELAYER 30 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 3
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L MCU_Microchip_ATmega:ATmega328P-AU U102
U 1 1 6005B7AE
P 3850 4300
F 0 "U102" H 3500 2800 50  0000 C CNN
F 1 "ATmega328P-AU" H 4300 2800 50  0000 C CNN
F 2 "Package_QFP:TQFP-32_7x7mm_P0.8mm" H 3850 4300 50  0001 C CIN
F 3 "http://ww1.microchip.com/downloads/en/DeviceDoc/ATmega328_P%20AVR%20MCU%20with%20picoPower%20Technology%20Data%20Sheet%2040001984A.pdf" H 3850 4300 50  0001 C CNN
	1    3850 4300
	1    0    0    -1  
$EndComp
$Comp
L Device:R R101
U 1 1 6005EBB7
P 4800 3750
F 0 "R101" H 4870 3796 50  0000 L CNN
F 1 "1M" H 4870 3705 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 4730 3750 50  0001 C CNN
F 3 "~" H 4800 3750 50  0001 C CNN
	1    4800 3750
	1    0    0    -1  
$EndComp
Wire Wire Line
	4700 3600 4700 3700
Wire Wire Line
	4700 3700 4450 3700
Connection ~ 4800 3600
Wire Wire Line
	4800 3600 4700 3600
Wire Wire Line
	4700 3900 4700 3800
Wire Wire Line
	4700 3800 4450 3800
Wire Wire Line
	4800 3900 4700 3900
$Comp
L Module-Central-rescue:RMF95-ProjetChambreFroide-Module-Central-rescue U103
U 1 1 600621C7
P 9350 3100
F 0 "U103" H 9375 3225 50  0000 C CNN
F 1 "RMF95" H 9375 3134 50  0000 C CNN
F 2 "Électrique:MOD_COM-13909" H 9350 3100 50  0001 C CNN
F 3 "" H 9350 3100 50  0001 C CNN
	1    9350 3100
	1    0    0    -1  
$EndComp
$Comp
L Connector:Conn_Coaxial J103
U 1 1 6006444E
P 10900 3900
F 0 "J103" H 11000 3875 50  0000 L CNN
F 1 "Conn_Coaxial" H 11000 3784 50  0000 L CNN
F 2 "Connector_Coaxial:SMA_Molex_73251-2200_Horizontal" H 10900 3900 50  0001 C CNN
F 3 " ~" H 10900 3900 50  0001 C CNN
	1    10900 3900
	1    0    0    -1  
$EndComp
Wire Wire Line
	10700 3900 9800 3900
$Comp
L power:GND #PWR0115
U 1 1 60065D11
P 10900 4100
F 0 "#PWR0115" H 10900 3850 50  0001 C CNN
F 1 "GND" H 10905 3927 50  0000 C CNN
F 2 "" H 10900 4100 50  0001 C CNN
F 3 "" H 10900 4100 50  0001 C CNN
	1    10900 4100
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0113
U 1 1 60065EA4
P 9800 3800
F 0 "#PWR0113" H 9800 3550 50  0001 C CNN
F 1 "GND" V 9805 3672 50  0000 R CNN
F 2 "" H 9800 3800 50  0001 C CNN
F 3 "" H 9800 3800 50  0001 C CNN
	1    9800 3800
	0    -1   -1   0   
$EndComp
$Comp
L power:GND #PWR0112
U 1 1 600660C0
P 8950 3900
F 0 "#PWR0112" H 8950 3650 50  0001 C CNN
F 1 "GND" H 8955 3727 50  0000 C CNN
F 2 "" H 8950 3900 50  0001 C CNN
F 3 "" H 8950 3900 50  0001 C CNN
	1    8950 3900
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0111
U 1 1 600662A6
P 8950 3200
F 0 "#PWR0111" H 8950 2950 50  0001 C CNN
F 1 "GND" V 8955 3072 50  0000 R CNN
F 2 "" H 8950 3200 50  0001 C CNN
F 3 "" H 8950 3200 50  0001 C CNN
	1    8950 3200
	0    1    1    0   
$EndComp
Text Label 4450 3400 0    50   ~ 0
MOSI_D11
Text Label 4450 3500 0    50   ~ 0
MISO_D12
$Comp
L Connector_Generic:Conn_02x03_Odd_Even J102
U 1 1 6006D884
P 6300 2250
F 0 "J102" H 6350 2567 50  0000 C CNN
F 1 "Prog" H 6350 2476 50  0000 C CNN
F 2 "Connector_PinSocket_2.54mm:PinSocket_2x03_P2.54mm_Vertical" H 6300 2250 50  0001 C CNN
F 3 "~" H 6300 2250 50  0001 C CNN
	1    6300 2250
	1    0    0    -1  
$EndComp
Text Label 4450 3600 0    50   ~ 0
SCK_D13
Wire Wire Line
	4450 3300 6300 3300
Wire Wire Line
	6300 3300 6300 3450
Wire Wire Line
	4450 3200 6400 3200
Wire Wire Line
	6400 3200 6400 3550
Text Label 4450 3200 0    50   ~ 0
D9
Text Label 4450 3300 0    50   ~ 0
D10
Text Label 6100 2150 2    50   ~ 0
MISO_D12
Text Label 6100 2250 2    50   ~ 0
SCK_D13
Text Label 6100 2350 2    50   ~ 0
RST
Text Label 6600 2250 0    50   ~ 0
MOSI_D11
$Comp
L power:GND #PWR0110
U 1 1 6007189E
P 6600 2350
F 0 "#PWR0110" H 6600 2100 50  0001 C CNN
F 1 "GND" H 6605 2177 50  0000 C CNN
F 2 "" H 6600 2350 50  0001 C CNN
F 3 "" H 6600 2350 50  0001 C CNN
	1    6600 2350
	1    0    0    -1  
$EndComp
Text GLabel 6600 2150 2    50   Input ~ 0
5V
Text Label 4950 4600 0    50   ~ 0
RST
Text Label 8950 3500 2    50   ~ 0
SCK_D13
$Comp
L Device:Jumper JP101
U 1 1 60072B85
P 6050 2800
F 0 "JP101" H 6050 3064 50  0000 C CNN
F 1 "Jumper" H 6050 2973 50  0000 C CNN
F 2 "Jumper:SolderJumper-2_P1.3mm_Open_Pad1.0x1.5mm" H 6050 2800 50  0001 C CNN
F 3 "~" H 6050 2800 50  0001 C CNN
	1    6050 2800
	1    0    0    -1  
$EndComp
$Comp
L Device:Jumper JP102
U 1 1 60074EF6
P 6050 3150
F 0 "JP102" H 6050 3414 50  0000 C CNN
F 1 "Jumper" H 6050 3323 50  0000 C CNN
F 2 "Jumper:SolderJumper-2_P1.3mm_Open_Pad1.0x1.5mm" H 6050 3150 50  0001 C CNN
F 3 "~" H 6050 3150 50  0001 C CNN
	1    6050 3150
	1    0    0    -1  
$EndComp
Wire Wire Line
	6350 3150 6500 3150
Wire Wire Line
	6500 3150 6500 3350
Wire Wire Line
	6600 3250 6600 2800
Wire Wire Line
	6600 2800 6350 2800
Text Label 5750 2800 2    50   ~ 0
MISO_D12
Text Label 5750 3150 2    50   ~ 0
MOSI_D11
$Comp
L Regulator_Linear:LM2937xMP U101
U 1 1 6007C9D9
P 4900 900
F 0 "U101" H 4900 1142 50  0000 C CNN
F 1 "LM2937xMP" H 4900 1051 50  0000 C CNN
F 2 "Package_TO_SOT_SMD:SOT-223-3_TabPin2" H 4900 1125 50  0001 C CIN
F 3 "http://www.ti.com/lit/ds/symlink/lm2937.pdf" H 4900 850 50  0001 C CNN
	1    4900 900 
	1    0    0    -1  
$EndComp
Text GLabel 4250 900  0    50   Input ~ 0
5V
$Comp
L Device:C C101
U 1 1 6007DD40
P 4400 1050
F 0 "C101" H 4515 1096 50  0000 L CNN
F 1 "0.1" H 4515 1005 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 4438 900 50  0001 C CNN
F 3 "~" H 4400 1050 50  0001 C CNN
	1    4400 1050
	1    0    0    -1  
$EndComp
Wire Wire Line
	4250 900  4400 900 
Connection ~ 4400 900 
Wire Wire Line
	4400 900  4600 900 
$Comp
L power:GND #PWR0102
U 1 1 6007EA94
P 4400 1200
F 0 "#PWR0102" H 4400 950 50  0001 C CNN
F 1 "GND" H 4405 1027 50  0000 C CNN
F 2 "" H 4400 1200 50  0001 C CNN
F 3 "" H 4400 1200 50  0001 C CNN
	1    4400 1200
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0103
U 1 1 6007EB1C
P 4900 1200
F 0 "#PWR0103" H 4900 950 50  0001 C CNN
F 1 "GND" H 4905 1027 50  0000 C CNN
F 2 "" H 4900 1200 50  0001 C CNN
F 3 "" H 4900 1200 50  0001 C CNN
	1    4900 1200
	1    0    0    -1  
$EndComp
$Comp
L Device:C C104
U 1 1 6007F0C1
P 5350 1050
F 0 "C104" H 5465 1096 50  0000 L CNN
F 1 "10" H 5465 1005 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 5388 900 50  0001 C CNN
F 3 "~" H 5350 1050 50  0001 C CNN
	1    5350 1050
	1    0    0    -1  
$EndComp
$Comp
L Device:C C106
U 1 1 6007F864
P 5700 1050
F 0 "C106" H 5815 1096 50  0000 L CNN
F 1 "0.1" H 5815 1005 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 5738 900 50  0001 C CNN
F 3 "~" H 5700 1050 50  0001 C CNN
	1    5700 1050
	1    0    0    -1  
$EndComp
Wire Wire Line
	5200 900  5350 900 
Connection ~ 5350 900 
Wire Wire Line
	5350 900  5700 900 
$Comp
L power:GND #PWR0105
U 1 1 6008030D
P 5350 1200
F 0 "#PWR0105" H 5350 950 50  0001 C CNN
F 1 "GND" H 5355 1027 50  0000 C CNN
F 2 "" H 5350 1200 50  0001 C CNN
F 3 "" H 5350 1200 50  0001 C CNN
	1    5350 1200
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0107
U 1 1 6008062E
P 5700 1200
F 0 "#PWR0107" H 5700 950 50  0001 C CNN
F 1 "GND" H 5705 1027 50  0000 C CNN
F 2 "" H 5700 1200 50  0001 C CNN
F 3 "" H 5700 1200 50  0001 C CNN
	1    5700 1200
	1    0    0    -1  
$EndComp
Text GLabel 5700 900  2    50   Input ~ 0
3V3
$Sheet
S 1450 2200 1500 1200
U 60082C21
F0 "Interface USB" 50
F1 "Interface USB.sch" 50
$EndSheet
Text GLabel 4450 4800 2    50   Input ~ 0
RX
Text GLabel 4450 4900 2    50   Input ~ 0
TX
Text GLabel 4950 4650 2    50   Input ~ 0
DTR
Wire Wire Line
	4950 4650 4950 4600
Wire Wire Line
	4950 4600 4450 4600
$Sheet
S 8650 4700 1200 950 
U 60095CF7
F0 "Thermomètres" 50
F1 "Thermomètres.sch" 50
$EndSheet
Text GLabel 4450 5100 2    50   Input ~ 0
1-Wire
Text GLabel 3900 2750 1    50   Input ~ 0
5V
Wire Wire Line
	3900 2750 3900 2800
Wire Wire Line
	3900 2800 3850 2800
Wire Wire Line
	3900 2800 3950 2800
Connection ~ 3900 2800
Text GLabel 3250 3100 0    50   Input ~ 0
5V
NoConn ~ 3250 3300
NoConn ~ 3250 3400
$Comp
L power:GND #PWR0106
U 1 1 600B4636
P 3850 5800
F 0 "#PWR0106" H 3850 5550 50  0001 C CNN
F 1 "GND" H 3855 5627 50  0000 C CNN
F 2 "" H 3850 5800 50  0001 C CNN
F 3 "" H 3850 5800 50  0001 C CNN
	1    3850 5800
	1    0    0    -1  
$EndComp
NoConn ~ 4450 4200
NoConn ~ 4450 4300
NoConn ~ 4450 4400
NoConn ~ 4450 4500
$Comp
L Device:LED D101
U 1 1 600B6061
P 5200 5900
F 0 "D101" V 5239 5782 50  0000 R CNN
F 1 "T0" V 5148 5782 50  0000 R CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 5200 5900 50  0001 C CNN
F 3 "~" H 5200 5900 50  0001 C CNN
	1    5200 5900
	0    -1   -1   0   
$EndComp
$Comp
L Device:LED D102
U 1 1 600B6C81
P 5550 5900
F 0 "D102" V 5589 5782 50  0000 R CNN
F 1 "T1" V 5498 5782 50  0000 R CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 5550 5900 50  0001 C CNN
F 3 "~" H 5550 5900 50  0001 C CNN
	1    5550 5900
	0    -1   -1   0   
$EndComp
$Comp
L Device:LED D103
U 1 1 600B8BF2
P 5850 5900
F 0 "D103" V 5889 5782 50  0000 R CNN
F 1 "T2" V 5798 5782 50  0000 R CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 5850 5900 50  0001 C CNN
F 3 "~" H 5850 5900 50  0001 C CNN
	1    5850 5900
	0    -1   -1   0   
$EndComp
$Comp
L Device:LED D104
U 1 1 600B8BF8
P 6200 5900
F 0 "D104" V 6239 5782 50  0000 R CNN
F 1 "T3" V 6148 5782 50  0000 R CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 6200 5900 50  0001 C CNN
F 3 "~" H 6200 5900 50  0001 C CNN
	1    6200 5900
	0    -1   -1   0   
$EndComp
$Comp
L Device:R R102
U 1 1 600BBBF2
P 5200 6200
F 0 "R102" H 5270 6246 50  0000 L CNN
F 1 "330" H 5270 6155 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 5130 6200 50  0001 C CNN
F 3 "~" H 5200 6200 50  0001 C CNN
	1    5200 6200
	1    0    0    -1  
$EndComp
$Comp
L Device:R R103
U 1 1 600BC202
P 5550 6200
F 0 "R103" H 5620 6246 50  0000 L CNN
F 1 "330" H 5620 6155 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 5480 6200 50  0001 C CNN
F 3 "~" H 5550 6200 50  0001 C CNN
	1    5550 6200
	1    0    0    -1  
$EndComp
$Comp
L Device:R R104
U 1 1 600BC54D
P 5850 6200
F 0 "R104" H 5920 6246 50  0000 L CNN
F 1 "330" H 5920 6155 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 5780 6200 50  0001 C CNN
F 3 "~" H 5850 6200 50  0001 C CNN
	1    5850 6200
	1    0    0    -1  
$EndComp
$Comp
L Device:R R105
U 1 1 600BC8A3
P 6200 6200
F 0 "R105" H 6270 6246 50  0000 L CNN
F 1 "330" H 6270 6155 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 6130 6200 50  0001 C CNN
F 3 "~" H 6200 6200 50  0001 C CNN
	1    6200 6200
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0108
U 1 1 600BD4CB
P 5200 6350
F 0 "#PWR0108" H 5200 6100 50  0001 C CNN
F 1 "GND" H 5205 6177 50  0000 C CNN
F 2 "" H 5200 6350 50  0001 C CNN
F 3 "" H 5200 6350 50  0001 C CNN
	1    5200 6350
	1    0    0    -1  
$EndComp
Wire Wire Line
	5200 5750 5200 5500
Wire Wire Line
	5200 5500 4450 5500
Wire Wire Line
	5550 5750 5550 5400
Wire Wire Line
	5550 5400 4450 5400
Wire Wire Line
	5850 5750 5850 5300
Wire Wire Line
	5850 5300 4450 5300
Wire Wire Line
	6200 5750 6200 5200
Wire Wire Line
	6200 5200 4450 5200
Text Notes 5300 5100 0    50   ~ 0
Port D garde meme numéro de pin que Arduino
Text Notes 8700 6300 0    50   ~ 0
Témoins lumineux facultatifs
NoConn ~ 9800 3200
NoConn ~ 9800 3300
Text GLabel 9800 3500 2    50   Input ~ 0
3V3
NoConn ~ 9800 3600
NoConn ~ 9800 3700
NoConn ~ 4450 3100
$Comp
L Device:C C107
U 1 1 600C5F44
P 5600 3600
F 0 "C107" V 5348 3600 50  0000 C CNN
F 1 "20p" V 5439 3600 50  0000 C CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 5638 3450 50  0001 C CNN
F 3 "~" H 5600 3600 50  0001 C CNN
	1    5600 3600
	0    1    1    0   
$EndComp
$Comp
L Device:C C108
U 1 1 600C6272
P 5600 3900
F 0 "C108" V 5850 3900 50  0000 C CNN
F 1 "20p" V 5750 3900 50  0000 C CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 5638 3750 50  0001 C CNN
F 3 "~" H 5600 3900 50  0001 C CNN
	1    5600 3900
	0    1    1    0   
$EndComp
Wire Wire Line
	5750 3600 5750 3750
$Comp
L power:GND #PWR0109
U 1 1 600C9449
P 5750 3750
F 0 "#PWR0109" H 5750 3500 50  0001 C CNN
F 1 "GND" V 5755 3622 50  0000 R CNN
F 2 "" H 5750 3750 50  0001 C CNN
F 3 "" H 5750 3750 50  0001 C CNN
	1    5750 3750
	0    -1   -1   0   
$EndComp
Connection ~ 5750 3750
Wire Wire Line
	5750 3750 5750 3900
Wire Wire Line
	5450 3600 5150 3600
Wire Wire Line
	5450 3900 5150 3900
$Comp
L Device:Crystal Y101
U 1 1 6005DE15
P 5150 3750
F 0 "Y101" V 5196 3619 50  0000 R CNN
F 1 "16MHz" V 5105 3619 50  0000 R CNN
F 2 "Crystal:Crystal_SMD_HC49-SD" H 5150 3750 50  0001 C CNN
F 3 "~" H 5150 3750 50  0001 C CNN
	1    5150 3750
	0    -1   -1   0   
$EndComp
Connection ~ 5150 3900
Connection ~ 5150 3600
Wire Wire Line
	4800 3600 5150 3600
Wire Wire Line
	4800 3900 5150 3900
NoConn ~ 8950 3800
$Comp
L Connector:Barrel_Jack J101
U 1 1 600715E8
P 1250 1000
F 0 "J101" H 1307 1325 50  0000 C CNN
F 1 "2.1mm X 5.5mm Barrel Connector" H 1307 1234 50  0000 C CNN
F 2 "Connector_BarrelJack:BarrelJack_Horizontal" H 1300 960 50  0001 C CNN
F 3 "~" H 1300 960 50  0001 C CNN
	1    1250 1000
	1    0    0    -1  
$EndComp
Text GLabel 1550 900  2    50   Input ~ 0
5V
$Comp
L power:GND #PWR0101
U 1 1 600732EF
P 1550 1100
F 0 "#PWR0101" H 1550 850 50  0001 C CNN
F 1 "GND" H 1555 927 50  0000 C CNN
F 2 "" H 1550 1100 50  0001 C CNN
F 3 "" H 1550 1100 50  0001 C CNN
	1    1550 1100
	1    0    0    -1  
$EndComp
$Comp
L Device:C C102
U 1 1 60076887
P 3300 2050
F 0 "C102" H 3415 2096 50  0000 L CNN
F 1 "0.1" H 3415 2005 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 3338 1900 50  0001 C CNN
F 3 "~" H 3300 2050 50  0001 C CNN
	1    3300 2050
	1    0    0    -1  
$EndComp
$Comp
L Device:C C103
U 1 1 6007714F
P 3650 2050
F 0 "C103" H 3765 2096 50  0000 L CNN
F 1 "0.1" H 3765 2005 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 3688 1900 50  0001 C CNN
F 3 "~" H 3650 2050 50  0001 C CNN
	1    3650 2050
	1    0    0    -1  
$EndComp
$Comp
L Device:C C105
U 1 1 60077E60
P 4000 2050
F 0 "C105" H 4115 2096 50  0000 L CNN
F 1 "0.1" H 4115 2005 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 4038 1900 50  0001 C CNN
F 3 "~" H 4000 2050 50  0001 C CNN
	1    4000 2050
	1    0    0    -1  
$EndComp
Wire Wire Line
	4000 2200 3650 2200
Connection ~ 3650 2200
Wire Wire Line
	3650 2200 3300 2200
Wire Wire Line
	3300 1900 3650 1900
Connection ~ 3650 1900
Wire Wire Line
	3650 1900 4000 1900
Text GLabel 3650 1900 1    50   Input ~ 0
5V
$Comp
L power:GND #PWR0104
U 1 1 6007AA63
P 3650 2200
F 0 "#PWR0104" H 3650 1950 50  0001 C CNN
F 1 "GND" H 3655 2027 50  0000 C CNN
F 2 "" H 3650 2200 50  0001 C CNN
F 3 "" H 3650 2200 50  0001 C CNN
	1    3650 2200
	1    0    0    -1  
$EndComp
$Comp
L Device:C C109
U 1 1 6007AF22
P 10150 3150
F 0 "C109" H 10265 3196 50  0000 L CNN
F 1 "0.1" H 10265 3105 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 10188 3000 50  0001 C CNN
F 3 "~" H 10150 3150 50  0001 C CNN
	1    10150 3150
	1    0    0    -1  
$EndComp
$Comp
L Device:C C110
U 1 1 6007B28B
P 10500 3150
F 0 "C110" H 10615 3196 50  0000 L CNN
F 1 "0.1" H 10615 3105 50  0000 L CNN
F 2 "Capacitor_SMD:C_0805_2012Metric" H 10538 3000 50  0001 C CNN
F 3 "~" H 10500 3150 50  0001 C CNN
	1    10500 3150
	1    0    0    -1  
$EndComp
Wire Wire Line
	10150 3300 10350 3300
Wire Wire Line
	10150 3000 10500 3000
$Comp
L power:GND #PWR0114
U 1 1 6007DF25
P 10350 3300
F 0 "#PWR0114" H 10350 3050 50  0001 C CNN
F 1 "GND" H 10355 3127 50  0000 C CNN
F 2 "" H 10350 3300 50  0001 C CNN
F 3 "" H 10350 3300 50  0001 C CNN
	1    10350 3300
	1    0    0    -1  
$EndComp
Connection ~ 10350 3300
Wire Wire Line
	10350 3300 10500 3300
Text GLabel 10350 3000 1    50   Input ~ 0
3V3
$Comp
L Device:LED D105
U 1 1 60196B8A
P 6600 5900
F 0 "D105" V 6639 5782 50  0000 R CNN
F 1 "TA" V 6548 5782 50  0000 R CNN
F 2 "Diode_SMD:D_0805_2012Metric" H 6600 5900 50  0001 C CNN
F 3 "~" H 6600 5900 50  0001 C CNN
	1    6600 5900
	0    -1   -1   0   
$EndComp
$Comp
L Device:R R106
U 1 1 60196B90
P 6600 6200
F 0 "R106" H 6670 6246 50  0000 L CNN
F 1 "330" H 6670 6155 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" V 6530 6200 50  0001 C CNN
F 3 "~" H 6600 6200 50  0001 C CNN
	1    6600 6200
	1    0    0    -1  
$EndComp
Text GLabel 6600 5750 1    50   Input ~ 0
5V
Connection ~ 4800 3900
NoConn ~ 4450 4000
NoConn ~ 4450 4100
Wire Wire Line
	5200 6350 5550 6350
Wire Wire Line
	8250 3550 8250 3700
Wire Wire Line
	8250 3700 8950 3700
Wire Wire Line
	8300 3450 8300 3600
Wire Wire Line
	8300 3600 8950 3600
Wire Wire Line
	8400 3350 8400 3400
Wire Wire Line
	8400 3400 8950 3400
Wire Wire Line
	8450 3250 8450 3300
Wire Wire Line
	8450 3300 8950 3300
Wire Wire Line
	9800 3400 9950 3400
Wire Wire Line
	9950 3400 9950 2800
Wire Wire Line
	9950 2800 8500 2800
Wire Wire Line
	8500 2800 8500 3150
Wire Wire Line
	7200 3550 6400 3550
Wire Wire Line
	7200 3450 6300 3450
Wire Wire Line
	6500 3350 7200 3350
Wire Wire Line
	6600 3250 7200 3250
Wire Wire Line
	4450 5000 6800 5000
Wire Wire Line
	6800 5000 6800 3150
Wire Wire Line
	6800 3150 7200 3150
$Comp
L Logic_LevelTranslator:FXMA108 U104
U 1 1 60399B14
P 7600 3450
F 0 "U104" H 7850 2800 50  0000 C CNN
F 1 "FXMA108" H 7850 2900 50  0000 C CNN
F 2 "Package_DFN_QFN:WQFN-20-1EP_2.5x4.5mm_P0.5mm_EP1x2.9mm" H 7600 2750 50  0001 C CNN
F 3 "http://www.onsemi.com/pub/Collateral/FXMA108-D.pdf" H 7600 3500 50  0001 C CNN
	1    7600 3450
	1    0    0    -1  
$EndComp
NoConn ~ 7200 3650
NoConn ~ 7200 3750
NoConn ~ 7200 3850
Wire Wire Line
	8500 3150 8000 3150
Wire Wire Line
	8450 3250 8000 3250
Wire Wire Line
	8400 3350 8000 3350
Wire Wire Line
	8300 3450 8000 3450
Wire Wire Line
	8250 3550 8000 3550
NoConn ~ 8000 3650
NoConn ~ 8000 3750
NoConn ~ 8000 3850
$Comp
L power:GND #PWR0116
U 1 1 603B0F0C
P 7200 3050
F 0 "#PWR0116" H 7200 2800 50  0001 C CNN
F 1 "GND" V 7205 2922 50  0000 R CNN
F 2 "" H 7200 3050 50  0001 C CNN
F 3 "" H 7200 3050 50  0001 C CNN
	1    7200 3050
	0    1    1    0   
$EndComp
Text GLabel 7500 2850 1    50   Input ~ 0
5V
Text GLabel 7700 2850 1    50   Input ~ 0
3V3
$Comp
L power:GND #PWR0117
U 1 1 603B1E4F
P 7600 4050
F 0 "#PWR0117" H 7600 3800 50  0001 C CNN
F 1 "GND" H 7605 3877 50  0000 C CNN
F 2 "" H 7600 4050 50  0001 C CNN
F 3 "" H 7600 4050 50  0001 C CNN
	1    7600 4050
	1    0    0    -1  
$EndComp
Connection ~ 5200 6350
Connection ~ 5550 6350
Wire Wire Line
	5550 6350 5850 6350
Connection ~ 5850 6350
Wire Wire Line
	5850 6350 6200 6350
Connection ~ 6200 6350
Wire Wire Line
	6200 6350 6600 6350
$EndSCHEMATC
