using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TileVania.Assets.Scripts
{
    public class ChangeScene : MonoBehaviour
    {
        public void ChangeScene1()
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}