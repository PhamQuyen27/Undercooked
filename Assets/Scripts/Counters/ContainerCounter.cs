using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    // check if player has kitchen object
    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            // player is not carrying anything

            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
/*            Transform kitchenObjectTransfrom = Instantiate(kitchenObjectSO.prefab);
            kitchenObjectTransfrom.GetComponent<KitchenObject>().SetKitchenObjectParent(player);*/

            OnPlayerGrabObject!.Invoke(this, EventArgs.Empty);
        }
    }
}
