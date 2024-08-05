using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    //check interact player with object kitchen
    public override void Interact(Player player)
    {     
        if (!HasKitchenObject())
        {
            //IF no kitchenobject here
            if (player.HasKitchenObject())
            {
                //player carry something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }else
            {
                //player not carry anything
            }
        }else
        {
            //there is a kitchenobject here
            if(player.HasKitchenObject())
            {
                // player is carry something

                if(player.GetKitchenObject().TryGetComponent(out PlateKitchenObject plateKitchenObject)) 
                {
                    // Player is holding a plate
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO()))
                    {
                        GetKitchenObject().DestroySelf();
                    }
                }else
                {
                    // Player is not carrying plate but something else
                    if(GetKitchenObject().TryGetPlate(out plateKitchenObject))
                    {
                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectSO()))
                        {
                            player.GetKitchenObject().DestroySelf() ;
                        }
                    }
                }
            }else
            {
                // plaer is not carry anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

}
