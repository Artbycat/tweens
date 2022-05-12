using UnityEngine;

public class Tweens : MonoBehaviour
{
    [SerializeField]
    AnimationCurve curva;

    [SerializeField]
    private float duracion = 5;

    [SerializeField]
    private Vector3 posInicial;

    [SerializeField]
    private Vector3 posFinal = Vector3.one;


    private void Update()
    {
        float tiempo = Time.time / duracion;
        transform.position = Vector3.LerpUnclamped(posInicial, posFinal, curva.Evaluate(tiempo));
    }
}

