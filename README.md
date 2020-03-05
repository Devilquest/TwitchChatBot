
# Twitch Chat Bot
### Bot per saludar i/o promocionar canals al xat de Twitch.
El “Bot” saludarà i/o promocionarà els canals desitjats pel xat de twitch cada cop (o segons la configuració) que un usuari parli pel xat.

## Configuració
Cal omplir els quatre camps de l’apartat de configuració:
 - **Canal:** Nom del canal de xat de Twitch al que es vol connectar.
 - **Usuari:** El teu nom d’usuari de Twitch.
 - **OAuth Token:** Cadena d’autentificació amb els permisos de `chat:read` i `chat:edit`. Es pot obtenir de forma automàtica fent clic [aquí](https://twitchtokengenerator.com/quick/nAkaeqVL46 "OAuth Token amb permisos chat:read i chat:edit") (l’enllaç genera el “Token” amb els permisos necessaris) o de forma manual a través de [twitchtokengenerator.com](http://twitchtokengenerator.com) (cal marcar els permisos de `chat:read` i `chat:edit`).
 - **Nom dels Canals o Spreadsheet ID:** Nom o noms dels canals a promocionar. En cas de posar més d’un canal han d’estar separats per comes. També es pot introduir el “Spreadsheet ID” d’un Google Spreadsheet amb el llistat de canals a promocionar a la primera columna. Es necessari que el Spreadsheet sigui [Publicat al Web](https://support.google.com/docs/answer/183965 "Publicar archivos de Documentos, Hojas de cálculo..."). En cas de només voler utilitzar la opció de “Saludar” aquest camp es pot deixar buit.
 - **Canals a ignorar:** Canal o canals que el "Bot" ignorarà. No els saludarà ni els promocionarà. En cas de posar més d’un canal han d’estar separats per comes.

## Ús
Un cop omplerts el camps de l’apartat de configuració per connectar el “Bot” prémer el boto “Connectar” i per desconnectar el boto “Desconnectar”.

Es poden canviar les opcions següents:
- **Saludar:** Si està marcada el “Bot” enviarà al xat el missatge “Hola + (Nom de l’usuari del Xat)” el primer cop que un usuari parli pel xat del canal configurat.
  - **A tothom:** Saludarà a tots els usuaris que parlin per primer cop al xat.
  - **Només als usuaris del llistat:** La funció de saludar només s’activarà si l’usuari que parla per primer cop en el xat és al llistat configurat a l’apartat “Nom dels Canals o Spreadsheet ID”.
- **Promocionar Canals:** Si està marcada el “Bot” enviarà al xat el missatge “(Nom de l’usuari del Xat) + a: (Url del canal de l’usuari) + és + (un elogi aleatori)”.
  - **Interval en minuts:** Mínim numero de minuts que han de passar per que el “Bot” promocioni el canal per segon cop.
  - **Interval de missatges:** Mínim número de missatges que un usuari ha d’enviar al xat perquè el “Bot” torni a promocionar el seu canal.

## Altres
La paraula de salutació i els elogis aleatoris es poden canviar al fitxer `BotSettings.cs` a les variables `HelloWord` i `Elogis`. En cas de canvi caldrà tornar a compilar el programa perquè els canvis tingui efecte.
