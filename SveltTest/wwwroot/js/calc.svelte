<svelte:options tag="calc-c" />
<script>
    let sum;
    let f = 1;
    let s = 12;

    function getSum(ff, ss){
         console.log(ff);
         console.log(ss);
         if(ff && ss){
             var nu = Number(ff) + Number(ss);
             console.log(nu);
             return nu;
         } else return 0;
    }

    $: sum = getSum(f,s);
    
</script>

<main>
    <input bind:value={f} />
    <input bind:value={s}  />
    <div>
    {sum} t
    </div>
</main>

<style>
    h1 {
        font-size: 5em;
    }
</style>