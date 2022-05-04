using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void Subscribe(IObserver observer);
    void Notify();
}