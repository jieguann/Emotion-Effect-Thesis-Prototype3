using UnityEngine;
using Unity.Barracuda;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace EmotionFerPlus {

public sealed class Test : MonoBehaviour
{
    #region Editable attributes

    [SerializeField] Texture2D _image = null;
    [SerializeField] RenderTexture renderTexture = null;
    [SerializeField] NNModel _model = null;
    [SerializeField] ComputeShader _preprocessor = null;
    [SerializeField] UnityEngine.UI.RawImage _preview = null;
    [SerializeField] UnityEngine.UI.Text _label = null;

    #endregion

    #region Compile-time constants

    const int ImageSize = 64;
        
    readonly static string[] Labels =
      { "Neutral", "Happiness", "Surprise", "Sadness",
        "Anger", "Disgust", "Fear", "Contempt"};

        #endregion
        //public float[] emotionState;
        #region MonoBehaviour implementation

        public List<string> emotionStates;

        
            public float happy;
            public float sad;
            public float anxious;
            public float angry;
            public float afraid;
            public float surprised;
            public float neutral;



        void Start()
    {

            emotionStates = new List<string>();

        }

        private void Update()
        {
            using var worker = ModelLoader.Load(_model).CreateWorker();
            // Preprocessing
            using var preprocessed = new ComputeBuffer(ImageSize * ImageSize, sizeof(float));
            _preprocessor.SetTexture(0, "_Texture", renderTexture);
            _preprocessor.SetBuffer(0, "_Tensor", preprocessed);
            _preprocessor.Dispatch(0, ImageSize / 8, ImageSize / 8, 1);

            // Emotion recognition model
            using (var tensor = new Tensor(1, ImageSize, ImageSize, 1, preprocessed))
                worker.Execute(tensor);

            // Output aggregation
            var probs = worker.PeekOutput().AsFloats().Select(x => Mathf.Exp(x));
            var sum = probs.Sum();
            var lines = Labels.Zip(probs, (l, p) => $"{l,-12}: {p / sum:0.00}");
            _label.text = string.Join("\n", lines);

            emotionStates.Clear();
            //float probsF[] = sum;
            foreach (var value in lines)
            {
                emotionStates.Add(value);
            }
            //print(emotionStates[0]);
            /*
             * The model outputs a (1x8) array of scores corresponding to the 8 emotion classes, 
             * where the labels map as follows: 
             * emotion_table = 
             * {'neutral':0, 'happiness':1, 'surprise':2, 'sadness':3, 'anger':4, 'disgust':5, 'fear':6, 'contempt':7}
             */
            //print(float.Parse(emotionStates[0].Substring(emotionStates[0].IndexOf(":") + 1)));
            happy = getFolatofEmotion(1);
            surprised = getFolatofEmotion(2);
            sad = getFolatofEmotion(3);
            angry = getFolatofEmotion(4);
            afraid = getFolatofEmotion(6);
            anxious = getFolatofEmotion(5);
            neutral = getFolatofEmotion(0);


            _preview.texture = renderTexture;
        }

        float getFolatofEmotion(int index)
        {
            return float.Parse(emotionStates[index].Substring(emotionStates[index].IndexOf(":") + 1));
        }

        #endregion
        
    }
    

} // namespace EmotionFerPlus
