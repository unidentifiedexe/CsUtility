# CsUtility  
## 概要  

C#での個人的に欲しいと思ったメソッドやあると便利かもと思ったメソッドを実装  

## 導入方法  
プロジェクトフォルダにある CsUtility.dll および CsUtility.xml をダウンロードすれば使用できます。

## EnumerableUtility  

IEnumerable型に関する操作をまとめたクラス  


### メソッドの概要

MinItem：最小値を持つ要素を取得  
MaxItem：最大値を持つ要素を取得  
MinMax：最小値と最大値のペアを取得  
MinMaxItem：最小値をもつ要素と最大値をもつの要素のペアを取得  
FirstOrDefault(func, defaultValue)：条件に合うものがなかった場合は指定されたデフォルト値を返す  
LastOrDefault(func, defaultValue)：条件に合うものがなかった場合は指定されたデフォルト値を返す  
ZipVicinity：前後のペアを取得する  
Split：指定数毎に区切る  
SplitIf：指定条件の時に区切る  
AggregateSelect：統計の途中情報を列挙  
Repeeat：ジェネレータを指定することにより、参照型において各個別のインスタンスの列挙を生成  


### 使い方  

工事中(使用例のコードを作成する予定)  

## PrimitiveUtility  
組み込み型に関するユーティリティメソッドをまとめたクラス。  

### メソッドの概要  
工事中  

### 使い方  
工事中  


## GenericUtility

ジェネリックの主にコレクション関係のユーティリティークラスを定義します。

### ReadSafeDictionary
読み取り時に```KeyNotFoundException```を発生させないディクリョナリクラスです。
読み取り時にキーに紐付された値が存在しない場合は、予め設定された規定値よりディクショナリの要素を追加します。

#### コード例
```cs
var dic = new ReadSafeDictionary("None");//規定値として"None"を与える
dic.Add( 0, "Zero");

Console.WriteLine(dic[10]);
//　出力：None
```

```cs
var nDic = new Dictionary();
Console.WriteLine(dic.GetValueOrDefault(10,"None"));//通常のディクショナリから安全に取り出せる。
//　出力：None
```
