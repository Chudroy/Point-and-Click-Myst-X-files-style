using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IContextMenuActionsGetter
{
    List<UnityAction> GetActions();
}
