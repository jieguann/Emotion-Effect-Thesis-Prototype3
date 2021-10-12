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
    }

    void Update()
    {
        Tensor input = new Tensor(textureInput);
        m_Worker.Execute(input);
        Tensor O = m_Worker.PeekOutput("output_layer_name");
        input.Dispose();
    }
}
