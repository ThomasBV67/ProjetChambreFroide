# ProjetChambreFroide
## Résumé du projet
Ce répertoire github contient tous les fichiers en lien avec notre projet. Ce projet se résume en un système de mesures et mise en mémoire de températures. Un module principal affiche les températures mesurée, garde en mémoire cette information et permet d'avoir accès à un historique des températures enregistrées. Un nombre variable de modules de mesures envoie des trames LoRa, contenant les températures mesurées par les capteurs de températures connectés à ceux-ci, au module principal.

## Dossiers
#### Électrique
Contient tout les fichiers et dossiers en lien avec la partie électronique du projet.

#### getAdressesCapteurs
Contient le projet arduino de test unitaire pour obtenir l'adresse des capteurs de températures.

#### LoRaSender
Contient le projet arduino de test unitaire d'envoi de trames LoRa.

#### ProgrammeModulesCentraux
Contient le projet arduino utilisé dans les modules de capteurs.

#### ProgrammePontLoRa
Contient le projet arduino utilisé pour faire le pont entre les trames LoRa et la connection série avec l'ordinateur.

#### testCapteurs
Contient le projet arduino utilisé pour tester le concept du projet (obtient les températures et envoi) du côté arduino.

#### TestPi
Contient le projet Visual Studio utilisé pour tester les fonctionnalitées de Windows 10 IoT Core.

#### TestRecieve
Contient le projet arduino utilisé pour tester la réception de trames LoRa.

#### TestSender
Contient le projet arduino utilisé pour tester l'envoi de trames LoRa.

#### UI_ChambreFroide_V1
Contient le projet principal Visual Studio.

## Fichiers
#### System.Data.SQLite.dll
Librairie utilisée pour utiliser SQLite dans le programme principal.

#### firstDraftUI_Projet.png
Idée de base pour l'affichage des températures

## Installation
#### Programme des cartes
Avant de mettre le programme spécifique à une carte, le bootloader doit etre installé. [Comment installer un bootloader](https://support.arduino.cc/hc/en-us/articles/360012048100-How-to-burn-the-bootloader-in-an-Arduino-Nano-using-an-Arduino-UNO)
Avant d'installer le bootloader, assurez vous que les jumpers JP101 et JP102 sont ouverts. Assurez vous de les fermer après son installation.
##### Module pont
Le programme du module pont est disponible sous /ProgrammePontLoRa/ProgrammePontLoRa.ino
Le fichier doit etre ouvert avec le logiciel Arduino.
Le programme est fait pour fonctionner avec les cartes "Module" disponibles sous /Électrique/Module Central/Module Central.pro
Compilez et envoyez le programme à la carte avec le logiciel Arduino
S'assurer que les syncWord des modules LoRa des modules correspondent (Disponibles entre 0x00 et 0xFF)
```c++
LoRa.setSyncWord(0x45);
```
##### Modules centraux
Le programme des modules centraux est disponible sous /ProgrammeModulesCentraux/ProgrammeModulesCentraux.ino
Le fichier doit etre ouvert avec le logiciel Arduino.
Le programme est fait pour fonctionner avec les cartes "Module" disponibles sous /Électrique/Module Central/Module Central.pro
Les cartes doivent etres numérotés. Il faut modifier la constante "NUM_MODULE" en commençant par 1 et en augmentant de 1 pour chaque module prévu sur le réseau
S'assurer que les syncWord des modules LoRa des modules correspondent (Disponibles entre 0x00 et 0xFF)
```c++
LoRa.setSyncWord(0x45);
```
Compilez et envoyez le programme à la carte avec le logiciel Arduino

#### Programme Principal
L'ensemble du programme principal est disponible sous /UI_ChambreFroide_V1/UI_ChambreFroide_V1/
Le projet s'ouvre avec visual studio. S'assurer que l'extensions "Développement .net Desktop" est installée dans VS

## Utilisation
### Commandes
Les commandes sont tout d'abord envoyés à partir d'un ordinateur vers le module de transmission qui se charge d'envoyer les informations de série vers LoRa et vice-versa. La commande est ensuite envoyée en LoRa et est reçue par tous les modules. Les modules vérifient ensuite l'information pour savoir si elle leur est destinée. Elle sera destinée à un seul module. Le module concerné traite ensuite la commande et récupère les informations demandés auprès des capteurs. Il renvois ensuite en un ou plusieurs messages dépendamment de la nature de la commande originale. Les données de réponses sont envoyées en LoRa et récupérés par le module de transmission qui les convertit en série et les renvoie à l'ordinateur. 

#### getAddr 
Commande permettant de lire l'adresse de tous les capteurs branchés à un module spécifié. 
Exemple d'utilisation: 1getAddr 

Le numéro du module interrogé est tout d'abord inséré suivi de la commande. La commande retourne  

Les adresses des différents capteurs qui y sont connectés sont envoyés, espacés par '#'

#### getTemp 
Commande retournant la température du thermomètre désiré.  

Exemple: 1getTemp-1 

Tout comme la première commande, le numéro de module est spécifié au départ. Le dernier chiffre correspond au numéro du thermomètre à lire. Le numéro correspond à la position d'arrivée de l'adresse dans la commande précédente.  

Le module interrogé renvoie une trame ressemblant à T#ADDR
Où T correspond à la température du capteur et ADDR à son addresse. L'addresse agit comme un checksum pour le programme principal.

### Principe de fonctionnement du programme principal
La prise de temprature par le programme principal fonctionne selon un principe d'action-réaction. Une premiere lecture est déclenchée par un timer, cette lecture est définie par l'envoi d'une commande "getTemp" et l'attente de sa réponse.
À partir de ce moment, deux actions sont possibles, soit la réponse du capteur est reçue, elle est donc validée et traitée. Soit un timer de timeout se déclenche, ce timer sert à protéger le programme contre les trames perdues. Lors de son déclenchement, le programme tentera de recontacter le capteur. Apres 4 essais échoués de suite, le programme abandonne, il marque donc le capteur comme déffectueux (La température est remplacé par "ERR" sur fond mauve.) et passe au prochain capteur.
