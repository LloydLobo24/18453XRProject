SpatialAudioLocal Project is the Ableton project

Unity (2022.3.48f1): 
Open new project in unity. 
Install Packages:-
Meta Interaction SDK and dependencies; 
extOSC; 

Add Scene, Materials, and Script from project
In Scene XRGrabOSC: 
    Update the ip address of the pc hosting ableton for each osc transmitter.

Ableton Live Studio: 
Download "Chop and Swing" and "Beat Tools" from https://www.ableton.com/en/live/compare-editions/#software-instruments
Download Envelope for live for spatial audio: https://envelop.us/page/software

Add in Patches-->trigger1, Patches-->trigger2, Patches-->trigger3 to each live track in the live set.  
Add in a E4L(Envelope for live) Master track 
Add a Stereo Panner into each track (this should be linked to the corresponding trigger patch)

With ableton running on a local pc, build and run the app on the meta quest3 via unity.  

Rotate the cube objects in the virtual space. 
Turn "on" the track by having the circle of the virtual object facing upwards and towards you. 
Move the virtual object around you to expereince spatial audio
