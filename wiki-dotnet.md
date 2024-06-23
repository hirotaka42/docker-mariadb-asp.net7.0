

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

パッケージのインストール
```
dotnet tool install --global dotnet-ef --version "7.*"
```

`dotnet aspnetcore-codegenerator` コマンドを使用し、CLIでのスキャフォールディングを実施

```
dotnet aspnetcore-codegenerator controller \
--model Product \
--dataContext ProductContext \ 
-name ProductController \
--no-build -outDir "./Controllers" \
--controllerNamespace Bff.Controllers \ 
--restWithNoViews \
--databaseProvider Pomelo.EntityFrameworkCore.MySql \

```

このコマンドの説明は以下の通り:

- `dotnet aspnetcore-codegenerator`: .NET Core CLI のコード生成ツールを呼び出す
- `controller`: コントローラーを生成するジェネレーターを指定
- `--model Product`: モデルクラスの名前を指定
- `--dataContext ProductContext`: DbContextクラスの名前を指定
- `-name ProductController`: 生成するコントローラークラスの名前を指定
- `--no-build`: ビルドを行わないように指定
- `-outDir "./Controllers"`: 生成したファイルの出力先ディレクトリを指定
- `--controllerNamespace Bff.Controllers`: コントローラークラスの名前空間を指定
- `--restWithNoViews`: REST API コントローラーを生成し、ビューは生成しないように指定
- `--databaseProvider Pomelo.EntityFrameworkCore.MySql`: データベースプロバイダーとして Pomelo.EntityFrameworkCore.MySql を使用するように指定

このコマンドを実行すると、同じ内容のスキャフォールディングが行われ、./Controllers/ProductController.cs にファイルが生成される