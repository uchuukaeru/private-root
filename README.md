# private-root
## 概要
素数の原子根を計算するプログラム

### 言語
C#
### 推奨実行環境
dotnet-SDK-6.0

## プログラム中に定義されている関数と構造体 -function & struct-
### namespace
proots

### class
proots

### 構造体  -struct-
#### proots.message
don't used -- 実装途中の仕様変更により未使用

##### 変数  -variavle-
public String mess;
public List<int> list;

##### 関数  -function-
###### ReadMess()
message構造体のmessを返す関数
引数:なし
返り値:String型変数

###### ReadList()
message構造体のlistを返す関数
引数:なし
返り値:int型リスト

### 関数    -function-
#### proots.Main()
メイン関数
引数:なし
返り値:なし
        
#### proots.ListWriteLine_int(List<int> list)
リストの要素をすべて表示する関数
引数:int型リスト
返り値:なし

#### proots.ArrayWriteLine_int(int[] Array)
配列の要素をすべて表示する関数
don't used -- デバッグ用関数
引数:int型配列
返り値:なし

#### proots.roots(int num)
原子根の計算関数
引数:int型変数
返り値:int型リスト
        
#### proots.roots_v2(int num)
原子根の計算関数
より巨大な数値に対応バージョン
引数:int型変数
返り値:int型リスト
            
#### proots.roots_v3(int num)
原子根の計算関数
より巨大な数値に対応バージョン
引数:int型変数
返り値:int型リスト
            
#### proots.roots_math(int i,int n,int num,int ind)
原子根の計算関数・再起関数
引数:int型変数4個
返り値:int型変数
            
#### proots.prime(int num)
素数判定関数
引数:int型変数
返り値:bool型変数

#### proots.dup(int[] test)
配列の重複確認関数
引数:int型配列
返り値:bool型変数

#### proots.dup_in_array(int[] test,int num)
配列の重複確認関数
引数:int型配列,int型変数
返り値:bool型変数

#### proots.roots_ob(int num)
原子根の計算関数
don't used -- 実装途中の仕様変更により未使用
引数:int型変数
返り値:message構造体{String型変数,int型リスト}

#### proots.Indent(int ind)
インデントをつける関数
don't used -- デバッグ用関数
引数:int型変数
返り値:なし