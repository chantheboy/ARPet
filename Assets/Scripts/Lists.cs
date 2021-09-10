using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    public Dictionary<string,string> categories;

    // Start is called before the first frame update
    void Start()
    {
        categories = new Dictionary<string, string>
        {
            { "person", "social" },
            { "bicycle", "fun" },
            { "car", "fun" },
            { "motorbike", "fun" },
            { "aeroplane", "fun" },
            { "bus", "fun" },
            { "train", "fun" },
            { "truck", "fun" },
            { "boat", "fun" },
            { "traffic light", "none" },
            { "fire hydrant", "none" },
            { "stop sign", "none" },
            { "parking meter", "none" },
            { "bench", "none" },
            { "bird", "social" },
            { "cat", "social" },
            { "dog", "social" },
            { "horse", "social" },
            { "sheep", "social" },
            { "cow", "social" },
            { "elephant", "social" },
            { "bear", "social" },
            { "zebra", "social" },
            { "giraffe", "social" },
            { "backpack", "none" },
            { "umbrella", "none" },
            { "handbag", "none" },
            { "tie", "none" },
            { "suitcase", "none" },
            { "frisbee", "fun" },
            { "skis", "fun" },
            { "snowboard", "fun" },
            { "sports ball", "fun" },
            { "kite", "fun" },
            { "baseball bat", "fun" },
            { "baseball glove", "fun" },
            { "skateboard", "fun" },
            { "surfboard", "fun" },
            { "tennis racket", "fun" },
            { "bottle", "none" },
            { "wine glass", "none" },
            { "cup", "none" },
            { "fork", "none" },
            { "knife", "none" },
            { "spoon", "none" },
            { "bowl", "none" },
            { "banana", "hunger" },
            { "apple", "hunger" },
            { "sandwich", "hunger" },
            { "orange", "hunger" },
            { "broccoli", "hunger" },
            { "carrot", "hunger" },
            { "hot dog", "hunger" },
            { "pizza", "hunger" },
            { "donut", "hunger" },
            { "cake", "hunger" },
            { "chair", "none" },
            { "sofa", "none" },
            { "pottedplant", "none" },
            { "bed", "none" },
            { "diningtable", "none" },
            { "toilet", "none" },
            { "tvmonitor", "none" },
            { "laptop", "fun" },
            { "mouse", "none" },
            { "remote", "none" },
            { "keyboard", "fun" },
            { "cell phone", "fun" },
            { "microwave", "none" },
            { "oven", "none" },
            { "toaster", "none" },
            { "sink", "none" },
            { "refrigerator", "none" },
            { "book", "fun" },
            { "clock", "none" },
            { "vase", "none" },
            { "scissors", "none" },
            { "teddy bear", "none" },
            { "hair drier", "none" },
            { "toothbrush", "none" },
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
