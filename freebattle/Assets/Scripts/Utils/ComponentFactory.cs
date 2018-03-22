using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum ComponentType
{
    Health,
    Movement,
    Buffcontainer,
}

public class ComponentFactory
{
    private Dictionary<ComponentType, List<BaseComponent>> factory;

    public BaseComponent Get(ComponentType type)
    {
        List<BaseComponent> pool;
        if(factory.TryGetValue(type,out pool))
        {
            BaseComponent res;
            if (pool.Count > 0)
            {
                res = pool[0];
                pool.RemoveAt(0);
                return res;
            }
            else
            {
                switch (type)
                {
                    case ComponentType.Health:
                        break;
                }
            }
        }
        else
        {
            pool = new List<BaseComponent>();
        }
    }
}
