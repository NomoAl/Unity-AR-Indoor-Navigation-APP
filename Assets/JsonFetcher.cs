using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class JsonFetcherAndSetPosition : MonoBehaviour
{
    private string apiUrlPrefix = "http://10.19.80.43:8000/api/wifidata/get-coordinates";
    [SerializeField] private GameObject start;

    void Start()
    {
        StartCoroutine(GetJsonAndUpdatePositionRoutine());
    }

    IEnumerator GetJsonAndUpdatePositionRoutine()
    {
        for (int i = 1; i <= 6; i++)
        {
            string apiUrl = apiUrlPrefix + i + "/";
            UnityWebRequest request = UnityWebRequest.Get(apiUrl);
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("Error fetching JSON from " + apiUrl + ": " + request.error);
            }
            else
            {
                string jsonData = request.downloadHandler.text;
                Debug.Log("Received JSON data from " + apiUrl + ": " + jsonData);

                SetStartPosition(jsonData);
            }

            yield return new WaitForSeconds(10f);
        }
    }

    void SetStartPosition(string json)
    {
        PositionData positionData = JsonUtility.FromJson<PositionData>(json);
        if (start != null && positionData != null)
        {
            Vector3 newPosition = new Vector3(positionData.x, positionData.y, positionData.z);
            start.transform.position = newPosition;
            Debug.Log("Start position set to: " + newPosition);
        }
        else
        {
            Debug.LogError("Failed to set start position. Ensure start is assigned and data is valid.");
        }
    }
}

[System.Serializable]
public class PositionData
{
    public float x;
    public float y;
    public float z;
}

