# ProjetChambreFroide
## Résumé du projet
Ce répertoire github contient tous les fichiers en lien avec notre projet. Ce projet se résume en un système de mesures et mise en mémoire de températures. Un module principal affiche les températures mesurée, garde en mémoire cette information et permet d'avoir accès à un historique des températures enregistrées. Un nombre variable de modules de mesures envoie des trames LoRa, contenant les températures mesurées par les capteurs de températures connectés à ceux-ci, au module principal.

## Dossiers
#### Électrique
Contient tout les fichiers et dossiers en lien avec la partie électronique du projet.

#### getAdressesCapteurs
Contient le projet arduino de test unitaire pour obtenir l'adresse des capteurs de températures.

#### GUI Élian
Contient le projet Visual Studio d'ébauche d'interface d'Élian.

#### LoRaSender
Contient le projet arduino de test unitaire d'envoi de trames LoRa.

#### ProgrammeModulesCentraux
Contient le projet arduino utilisé dans les modules de capteurs.

#### ProgrammePontLoRa
Contient le projet arduino utilisé pour faire le pont entre les trames LoRa et la connection série avec le Pi.

#### testCapteurs
Contient le projet arduino utilisé pour tester le concept du projet (obtient les températures et envoi) du côté arduino.

#### TestPi
Contient le projet Visual Studio utilisé pour tester les fonctionnalitées de Windows 10 IoT Core.

#### TestRecieve
Contient le projet arduino utilisé pour tester la réception de trames LoRa.

#### TestSender
Contient le projet arduino utilisé pour tester l'envoi de trames LoRa.

#### testUnitaireLoRaReceiver
Contient le projet arduino utilisé pour tester la réception de trames LoRa.

#### UI_ChambreFroide_V1
Contient le projet principal Visual Studio.

## Fichiers
#### System.Data.SQLite.dll
Librairie utilisée pour utiliser SQLite dans le programme principal.

#### firstDraftUI_Projet.png
Idée de base pour l'affichage des températures
