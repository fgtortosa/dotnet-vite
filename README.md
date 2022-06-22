# dotnet-vite

### Enlaces para la configuracion
 
 - [Crear una plantilla a partir de la plantilla de Angular](https://www.dotnetcurry.com/aspnet-core/1525/angular-react-vuejs-svelte-spa-aspnet-core-3)
 - [Configuracion desde zero de una aplicacion Net Core 3 para funcionar con Vue utilizando vue-cli. Útil para el funcionamiento de Axios](https://www.freecodecamp.org/news/how-to-build-an-spa-with-vuejs-and-c-using-net-core/)
- [Configuración de Net Core 3 con VueCliProxy](https://intellitect.com/blog/vue-cli-net-core-3-1/)
- [Otro de Net Core 3 y Vue, en este caso con vue sin compilar](https://intellitect.com/blog/vue-cli-net-core-3-1/)

### Uso de Vue con TypeScript

- [https://github.com/lucasrocha1313/solar-coffe-web.git](Ejemplo con vue-cli)
- [https://github.com/JDN89/dotnet-vue-todo-app](Ejemplo con Dapper, Vue, TypeScript: se debe de utilizar como modelo de aplicación)
- 
### Configuracion de vite

Para utilizar la @ en los imports, se debe configurar el proyecto con el siguiente comando:
VITE: Dentro de DefineConfig

```
resolve: {
      alias: [{ find: "@", replacement: path.resolve(__dirname, "src") }],
    }, 
```


### Plantillas

- [Plantilla NetCore 6 para Vite](https://marketplace.visualstudio.com/items?itemName=MakotoAtsu.AspNetCoreViteStarter)
- [Plantilla NetCore5 para Vite y React](https://github.com/martijnboland/LeanAspNetCore-React). Interesante el Middleware para arrancar vite.
- [Plantilla NetCore 6 para Vite y Vue](https://github.com/JonathanHope/spa-bfff/tree/main/src). Es la que he utilizando como modelo. He añadido la configuracion Cors. Para la explicación de como funciona la plantilla y como hacer el build el producción ver [este blog](https://jho.pe/posts/vite-aspnetcore-bff/)


