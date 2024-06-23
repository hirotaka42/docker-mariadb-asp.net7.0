

## パッケージのインストール
メジャーバージョン7における最新のマイナーバージョンやパッチバージョンが自動的に選択される

```
dotnet add package Microsoft.EntityFrameworkCore --version "7.*"
dotnet add package Microsoft.EntityFrameworkCore.Design --version "7.*"
dotnet add package Microsoft.EntityFrameworkCore.Tools --version "7.*" 
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version "7.*"
```

### MS SQLサーバーを利用する場合は以下を追加
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version "7.*" 
```

### MySqlを利用する場合は以下を追加
```
dotnet add package Microsoft.EntityFrameworkCore.Relational --version "7.*" 
dotnet add package Pomelo.EntityFrameworkCore.MySql --version "7.*"
```

### SQLiteを利用する場合は以下を追加

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version "7.*" 
dotnet add package Microsoft.EntityFrameworkCore.SqliteCore --version "7.*" 
```


## マイグレーション

```
dotnet tool install --global dotnet-ef --version "7.*"

```