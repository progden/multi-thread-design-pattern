# multi-thread-design-pattern

## Single Thread Execution Pattern

![title](./images/001-1.png)

1. 共用的資源

待補充

2. 有使用到共用資源的 _非執行續安全方法_ 與 沒有用到共用資源的 _執行續安全方法_

待補充

## Immutable Pattern

程式待補

1. 不會被外部改變的共用資源

待補充

## Guarded Suspension Pattern

程式待補

1. 保護條件

通過條件才能操作物件，不符合會等待

待補充

## Balking Pattern

待補充

1. 保護條件

類似 Guarded Suspension Pattern

但當不符合條件的時候，worker 不會等待

待補充

## Producer-Consumer Pattern

程式待補充

1. 生產者 & 消費者

待補充

2. Buffer or Queue

待補充

## Read-Write Lock Pattern

Multi-Read & One-Write

待補充

## Thread-Per-Message Pattern

每個訊息都要專人服務

待補充

## Worker Thread Pattern

一群 worker 來處理工作

待補充

## Future Pattern

先給你 TOKEN，好了再來認 TOKEN 取貨

待補充

## Two-Phase Termination Pattern

安全的終止，儘快的結束

待補充

## Thread-Speccific Storage Pattern

每個執行續特有的 Storage

待補充

## Active Object Pattern

1. Client: 發出請求，等待結果
2. Producer-Consumer Pattern 處理請求，建立結果
3. Future Pattern 非同步的回傳結果

待補充
