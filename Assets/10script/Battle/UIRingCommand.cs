using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class UIRingCommand : UIBehaviour, ILayoutGroup {

    public Vector3 offsetPosition = new Vector3(0f, 0f, 0f);
    public float offsetAngle;
    public Vector3 distance = new Vector3(0f, 100f, 0f);
    public float maxAngle = 360f;
    public int currentItemIndex;
    public bool isShow;
    public bool isArcMode;
    public float speed = 10f;

    private List<RectTransform> items = new List<RectTransform>();
    private RectTransform rectTransform;
    private Vector3 currentDistance;
    private float currentItemMaxAngle;
    private float currentBaseCircleAngle;
    private float itemAngleStep;

    private float LerpSpeed {
        get { return speed * Time.deltaTime; }
    }

    void RefreshItemList() {
        items.Clear();
        foreach (RectTransform t in transform) {
            items.Add(t);
        }
    }

    protected override void Start() {
        base.Awake();
        rectTransform = GetComponent<RectTransform>();
        RefreshItemList();
    }

    void Update() {
        UpdateValues();
        for (int idx = 0; idx < items.Count; idx++) {
            items[idx].anchoredPosition3D =
                Quaternion.Euler(0f, 0f, itemAngleStep * idx) * // それぞれのアイテムの位置に回転。
                Quaternion.Euler(0f, 0f, currentBaseCircleAngle - offsetAngle) * // 選択中のアイテムIdxに応じて回転。
                currentDistance + offsetPosition;
        }
    }

    void UpdateValues() {
        itemAngleStep = Mathf.Lerp(itemAngleStep, currentItemMaxAngle / items.Count, LerpSpeed * 2f);

        if (isArcMode) {
            currentDistance = rectTransform.anchoredPosition3D + distance;
        } else {
            currentDistance = Vector3.Lerp(
            currentDistance,
            (isShow ? rectTransform.anchoredPosition3D + distance : Vector3.zero),
            LerpSpeed);
        }

        if (isArcMode) {
            currentItemMaxAngle = Mathf.Lerp(
                currentItemMaxAngle,
                (isShow ? -maxAngle : 0f),
                LerpSpeed);
        } else {
            currentItemMaxAngle = -maxAngle;
        }

        currentBaseCircleAngle = Mathf.Lerp(
            currentBaseCircleAngle,
            -itemAngleStep * currentItemIndex,
            LerpSpeed);
    }

    #region ILayoutGroup
    // UI要素変化時のコールバック
    // 両方呼ばれるようなので、片方でだけアイテムリストの更新を行う。
    public void SetLayoutHorizontal() {
        RefreshItemList();
    }
    public void SetLayoutVertical() { }
    #endregion
}