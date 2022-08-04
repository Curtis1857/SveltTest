<svelte:options tag="moving-element" />
<script>
    
    export let elements = ["cat", "dog", "shoe"];
    
    
</script>

<main>

    {#each elements as el }
        <div> U+1F69C </div>
    {/each}
</main>

<style>
    div {
       /*animation: slide 1000ms;*/
       animation: slide 1s linear 0s infinite;
    }
    main{
        height: 100vh;
    }

    /*@keyframes slide {
      from {top:-100px}; 
      to {top:800px};     
    }*/
    @keyframes slide {
        from {
            transform: translate(0%, 0%);
            /*transform: translateX(-10%);*/
        }
        to {
            transform: translate(100%, 800px);
            /*transform: translateX(100%);*/
        }
    }
</style>