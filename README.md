# VR Kunsthalle Karlsruhe

## Programmversionen

| Programm       | Version       |
|----------------|---------------|
| Unity          | [2018.4.21f1] |


## Kurzbeschreibung

Unsere VR Anwendung für die Kunsthalle Karlsruhe, soll die Werke des Kupferstichkabinetts für den Besucher erlebbarer machen und damit die jüngere Generation ansprechen.
Neben der Möglichkeit die Werke virtuell zu betrachten ist es möglich die immersive Szenerie des jeweiligen Werkes zu betreten, welches aus den verschiedenen Elementen und der entsprechenden Farbstimmung erstellt wurde. Dorthin gelangt man, indem man das Bild abhängt und auf den Tisch in der Mitte des virtuellen Ausstellungsraums legt. Der Austellungsraum stellt dabei den Ausgangspunkt der Anwendung dar.


## Kurzdokumentation

#### Interaktion

Man bewegt sich in der Szene durch Teleportation fort und kann auf diese Weise die weiteren Bilder in dem virtuellen Austellungsraum betrachten. Außerdem lassen sich diese in die Hand nehmen und anschließend vergrößern bzw. verkleinern, indem man auf die Symbole neben dem Bild tippt.
Durch greifen und ablegen auf den Teleport Tisch in der Mitte der Szene können die Szenerien betreten werden. Zurück kommt man wieder, wenn man das Bild vom Tisch nimmt.

Die aktuell betretbaren Szenerien sind
- Melancholia von Dürer
- Rhinocerus von Dürer

#### Dateien und Struktur

Die Hauptszene benannt als MainScene.unity befindet sich im Assets Ordner unter Scenes.

Die folgenden 3D Objekte stammen aus dem Internet und wurden von uns angepasst:
- Austellungsraum:
  - https://assetstore.unity.com/packages/3d/environments/showroom-environment-73740
- Dürers Solid:
  - https://3dwarehouse.sketchup.com/model/b7f5da4c3e3575916f818f254c82cbd4/D%C3%BCrers-Solid
- Rhino:
  - https://sketchfab.com/3d-models/tribal-like-white-rhinoceros-594531b338104329ba6c65aac367bd07
- Safari Jeep: 
  - https://sketchfab.com/3d-models/jeep-willys-50fae79d1fcf48bcb5e2b453c2deef13
  - https://sketchfab.com/3d-models/jeep-2bd5190f88c740d0af3ed616d33adc75

Für die verschiedenen Interaktionen wurden die Prefabs aus der VRTK Library verwendet.

#### Technisches

Die Anwendung wurde für die Verwendung einer Oculus VR-Brille konfiguriert und auch nur damit getestet.
Die Anbindung mit SteamVR wurde zwar integriert konnte aber nicht getestet werden und muss in Unity unter den Camerarigs gegebenenfalls umgestellt bzw. aktiviert werden.

Die ausführbare .exe Datei kann über den bereitgestellten Google Drive Link im Build Ordner oder direkt über diesen Link heruntergeladen und ausgeführt werden.
- https://drive.google.com/file/d/1hOlpZxo3-SpW4jOx7GW_vBzjfK8N-MV2/view?usp=sharing

## Screenshots

Fügen Sie hier die Screenshots aus Ihrem Screenshots-Verzeichnis ein und versehen Sie die Bilder mit einer knappen Bildunterschrift zur Erklärung.

<div>
  <img src="/Screenshots/MainRoom.jpg?raw=true" width="48%" style="display:inline; margin:1%">
  <p>Austellungsraum und Ausgangspunkt der Anwendung</p>
  <img src="/Screenshots/PaintingsAndTeleporter.jpg?raw=true" width="48%" style="display:inline; margin:1%">
  <p>Betretbare Bilder und Teleporttisch</p>
  <img src="/Screenshots/MelancholiaScene.jpg?raw=true" width="48%" style="display:inline; margin:1%">
  <p>Szenerie des Werkes Melancholia von Dürer</p>
  <img src="/Screenshots/RhinoScene.jpg?raw=true" width="48%" style="display:inline; margin:1%">
  <p>Szenerie des Werkes Rhinocerus von Dürer</p>
</div>

## Sonstiges (optional)

Sie können die ReadMe.md sehr gerne nutzen, um weitere Informationen zu Ihrem Projekt festzuhalten.
Denken Sie daran, keine vertraulichen Daten wie Matr.Nr. oder ihre Namen auf einer externen Plattform zu hinterlegen. Sobald ihr Repo abgabefertig eingerichtet ist,
senden Sie uns eine Benachrichtigung über die Hochschulemailadresse. 
