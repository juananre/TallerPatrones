using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour, ISubject
{
    [SerializeField] ObserverColor observer1;
    private readonly List<IObserver> observers = new List<IObserver>();
    // Start is called before the first frame update
    void Start()
    {
        Subscribe(observer1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) Notify();
    }

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Notify()
    {
        foreach(var _observer in observers)
        {
            _observer.OnButtonClicked(this);
        }
        
    }
}
