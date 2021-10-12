using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda;
public class BarracudaRunner : MonoBehaviour
{
    public NNModel modelAsset;
    public Texture2D textureInput;
    private Model m_RuntimeModel;
    private IWorker m_Worker;
    public WorkerFactory.Type WorkerType = WorkerFactory.Type.Auto;
    void Start()
    {
        
        m_RuntimeModel = ModelLoader.Load(modelAsset);
        m_Worker = WorkerFactory.CreateWorker(WorkerType, m_RuntimeModel);
        //print(m_Worker.PeekOutput(outputLayer0));
        foreach (var layer in m_RuntimeModel.layers)
            Debug.Log(layer.name + " does " + layer.type);
    }

    Tensor[] b_outputs = new Tensor[4];
    void Update()
    {
        
        Tensor input = new Tensor(textureInput,3);
        m_Worker.Execute(input);
        
        
        input.Dispose();
        
    }
}
