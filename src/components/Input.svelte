<script>
    export let autoexpand = false;
</script>

<style>
    input {
        border: 3px double var(--primary-accent-color);
    }

    input,
    select,
    .auto-expanding {
        font-family: "Fira Mono", "Consolas", monospace;
        font-size: 1.2rem;
        line-height: 1.5;
        width: 100%;
        outline: initial;
    }

    input,
    select,
    .auto-expanding {
        padding: 0.5rem 0.7rem;
        border-radius: 0 !important;
        border: 3px double var(--primary-accent-color);
        -webkit-appearance: none;
        -moz-appearance: none;
        appearance: none;
        box-sizing: border-box;
        background-color: #fff;
    }

    .auto-expanding span:empty::before,
    *::placeholder {
        opacity: 0.6;
        color: #000;
        font-style: italic;
    }

    :focus,
    .auto-expanding:focus-within {
        border-style: solid;
    }

    .auto-expanding span:empty::before {
        height: 0;
        display: inline-block;
        content: attr(placeholder);
    }

    .auto-expanding span:focus {
        border: none;
        outline: none;
    }

    .auto-expanding span {
        width: 100%;
        display: block;
    }
</style>

{#if !autoexpand}
    {#if !$$slots.default}
        <input {...$$restProps} />
    {:else}
        <select {...$$restProps}>
            <slot />
        </select>
    {/if}
{:else}
    <!-- TODO: Figure out if wrapper div can be elimiated -->
    <div class="auto-expanding">
        <span
            contenteditable
            {...$$restProps}
            role="textbox"
            aria-multiline="true" />
    </div>
{/if}
