using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DressUpManager : MonoBehaviour
{
    public List<DressingUpItem> ClothSlotPrefabs;
    public List<DraggableItem> ClothingPiecePrefab;
    public Transform slotParant, pieceParant;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        var randomSet = ClothSlotPrefabs.OrderBy(s => Random.value).Take(3).ToList();

        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedSlot = Instantiate(randomSet[i], slotParant.GetChild(i).position,Quaternion.identity);

            var spawnedPiece = Instantiate(randomSet[i], pieceParant.GetChild(i).position, Quaternion.identity);
            spawnedPiece.Init(spawnedSlot);
        }
     }




}
