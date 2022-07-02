using Cysharp.Threading.Tasks;
using Microsoft.MixedReality.Toolkit.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DataSourceJsonTest : DataSourceGOJson
{
    [Tooltip("URL for a json data source")]
    [SerializeField]
    private string url = "http://www.boredapi.com/api/activity";

    [Tooltip("How many seconds between fetching the data source and notifying all consumer of changes.")]
    [SerializeField]
    private float secondsBetweenFetches = 15.0f;

    protected float _time = 0.0f;

    protected override void InitializeDataSource()
    {
        _time = secondsBetweenFetches;
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= secondsBetweenFetches)
        {
            _time -= secondsBetweenFetches;

            string jsonText = "{\"greeting\":{\"message\":\"Hello World\"},\"name\":\"hogehoge\"}";
            DataSourceJson.UpdateFromJson(jsonText);
            DataSourceObjects
        }
    }
}


