# private-root<br>
## 概要<br>
素数の原始根を計算するプログラム<br>

### 言語<br>
C#<br>
### 推奨実行環境<br>
dotnet-SDK-6.0<br>

## プログラム中に定義されている関数と構造体 -function & struct-<br>
### namespace<br>
proots<br>
<hr><br>

### class<br>
proots<br>
<hr><br>

### 構造体  -struct-<br>
#### proots.message<br>
don't used -- 実装途中の仕様変更により未使用<br>

##### 変数  -variavle-<br>
public String mess;<br>
public List<int> list;<br>

##### 関数  -function-<br>
###### ReadMess()<br>
message構造体のmessを返す関数<br>
引数:なし<br>
返り値:String型変数<br>

###### ReadList()<br>
message構造体のlistを返す関数<br>
引数:なし<br>
返り値:int型リスト<br>
<hr><br>

### 関数    -function-<br>
#### proots.Main()<br>
メイン関数<br>
引数:なし<br>
返り値:なし<br>
        
#### proots.ListWriteLine_int(List<int> list)<br>
リストの要素をすべて表示する関数<br>
引数:int型リスト<br>
返り値:なし<br>

#### proots.ArrayWriteLine_int(int[] Array)<br>
配列の要素をすべて表示する関数<br>
don't used -- デバッグ用関数<br>
引数:int型配列<br>
返り値:なし<br>

#### proots.roots(int num)<br>
原子根の計算関数<br>
引数:int型変数<br>
返り値:int型リスト<br>
        
#### proots.roots_v2(int num)<br>
原子根の計算関数<br>
より巨大な数値に対応バージョン<br>
引数:int型変数<br>
返り値:int型リスト<br>
            
#### proots.roots_v3(int num)<br>
原子根の計算関数<br>
より巨大な数値に対応バージョン<br>
引数:int型変数<br>
返り値:int型リスト<br>
            
#### proots.roots_math(int i,int n,int num,int ind)<br>
原子根の計算関数・再起関数<br>
引数:int型変数4個<br>
返り値:int型変数<br>
            
#### proots.prime(int num)<br>
素数判定関数<br>
引数:int型変数<br>
返り値:bool型変数<br>

#### proots.dup(int[] test)<br>
配列の重複確認関数<br>
引数:int型配列<br>
返り値:bool型変数<br>

#### proots.dup_in_array(int[] test,int num)<br>
配列の重複確認関数<br>
引数:int型配列,int型変数<br>
返り値:bool型変数<br>

#### proots.roots_ob(int num)<br>
原子根の計算関数<br>
don't used -- 実装途中の仕様変更により未使用<br>
引数:int型変数<br>
返り値:message構造体{String型変数,int型リスト}<br>

#### proots.Indent(int ind)<br>
インデントをつける関数<br>
don't used -- デバッグ用関数<br>
引数:int型変数<br>
返り値:なし<br>
