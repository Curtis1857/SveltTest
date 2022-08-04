<svelte:options tag="infinite-scroll" />
<script>
    
    //export let elements = ["cat", "dog", "shoe"];
    export let elements;
    
</script>

<main>

    {#each elements.split(", ") as el }
        <div> {el} </div>
    {/each}
</main>

<style>
    h1 {
        font-size: 5em;
    }
</style>