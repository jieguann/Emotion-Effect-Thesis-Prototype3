# Emotion-Effect
The first prototype (see Fig 1) attempts to explore the relationship between human emotion and colour to provide a virtual environment that reflects the human's emotional state. Based on the deep networks for the facial expression recognition model (Barsoum et al.), the system is able to recognize the human emotional state from video resources or real-time video. The model is able to provide seven states of the emotion with scores (neutral, happiness, surprise, sadness, anger, disgust, fear, contempt) that can be mapped into the colour that developed based on Jamet's emotion colour wheel (see Fig 2).

![Capture](https://user-images.githubusercontent.com/60665347/138810981-c7f680ab-f7f2-4061-a760-e934d37dda7e.PNG)

https://www.youtube.com/watch?v=HpYXZP1bDPc&t=7s

Although the emotion recognition part should be supported by computer vision and deep learning, the trained model could be found on the internet and be used directly in the application. In terms of the reflection of the emotion in colour, there are various model could be choice (Nijdam) and the project start with the simple one (Jamet's emotion colour wheel). Fig 3 demonstrates the sketch of the concept of turn emotion into colour, and Fig 4 and 5 show the process of the work.


## Reference
Emotion Model https://github.com/onnx/models/tree/master/vision/body_analysis/emotion_ferplus \
Emotions States Map to Color https://blossomireland.ie/body-maps-and-emotions-colour-wheel/ 


## Credits
Video for Test https://www.youtube.com/watch?v=B0ouAnmsO1Y \
Emotion Fer Plus in Unity https://github.com/keijiro/EmotionFerPlus \
Barsoum, Emad, et al. "Training deep networks for facial expression recognition with crowd-sourced label distribution." Proceedings of the 18th ACM International Conference on Multimodal Interaction. 2016.\
Jamet, Clemence. "Body Maps and Emotion Colour Wheel." Blossom Ireland, 25 May 2020, https://blossomireland.ie/body-maps-and-emotions-colour-wheel/. \
Nijdam, Niels A. "Mapping emotion to color." Book Mapping emotion to color (2009): 2-9.




## Pre-resesearch
Unity Youtube Player https://github.com/jieguann/UnityYoutubePlayer \
moodme-emotions Free Version https://assetstore.unity.com/packages/add-ons/machinelearning/moodme-emotions-barracuda-sdk-191930 \
Emotion Model https://github.com/onnx/models/tree/master/vision/body_analysis/emotion_ferplus \
Emonet https://github.com/face-analysis/emonet \
Pytorch to ONNX https://github.com/onnx/tutorials/blob/master/tutorials/PytorchOnnxExport.ipynb \
Unity Barracuda https://github.com/Unity-Technologies/barracuda-release \
ThreeDPoseUnityBarracuda https://github.com/digital-standard/ThreeDPoseUnityBarracuda \
emotions-barracuda-sdk https://assetstore.unity.com/packages/tools/ai/moodme-4-emotions-barracuda-sdk-202171
